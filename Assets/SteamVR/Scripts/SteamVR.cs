//========= Copyright 2014, Valve Corporation, All rights reserved. ===========
//
// Purpose: Access to SteamVR system (hmd) and compositor (distort) interfaces.
//
//=============================================================================

using UnityEngine;
using System.Runtime.InteropServices;
using System.IO;
using Valve.VR;

public class SteamVR : System.IDisposable
{
	// Use this to check if SteamVR is currently active without attempting
	// to activate it in the process.
	public static bool active { get { return _instance != null; } }

	private static SteamVR _instance;
	public static SteamVR instance
	{
		get
		{
			if (_instance == null)
				_instance = CreateInstance();
			return _instance;
		}
	}

	static SteamVR CreateInstance()
	{
		var error = HmdError.None;
		var pHmd = OpenVR.Init(ref error);
		ReportError(error);

		if (pHmd == System.IntPtr.Zero || error != HmdError.None)
		{
			ShutdownSystems();
			return null;
		}

		// Make sure we're using the proper version
		pHmd = OpenVR.GetGenericInterface(OpenVR.IVRSystem_Version, ref error);
		ReportError(error);

		if (pHmd == System.IntPtr.Zero || error != HmdError.None)
		{
			ShutdownSystems();
			return null;
		}

		var pCompositor = OpenVR.GetGenericInterface(OpenVR.IVRCompositor_Version, ref error);
		ReportError(error);

		if (pCompositor == System.IntPtr.Zero || error != HmdError.None)
		{
			ShutdownSystems();
			return null;
		}

		var pOverlay = OpenVR.GetGenericInterface(OpenVR.IVROverlay_Version, ref error);
		ReportError(error);

		if (pOverlay == System.IntPtr.Zero || error != HmdError.None)
		{
			ShutdownSystems();
			return null;
		}

		return new SteamVR(pHmd, pCompositor, pOverlay);
	}

	static void ReportError(HmdError error)
	{
		switch (error)
		{
			case HmdError.None:
				break;
			case HmdError.VendorSpecific_UnableToConnectToOculusRuntime:
				Debug.Log("SteamVR Initialization Failed!  Make sure device is on, Oculus runtime is installed, and OVRService_*.exe is running.");
				break;
			case HmdError.Init_VRClientDLLNotFound:
				Debug.Log("SteamVR drivers not found!  They can be installed via Steam under Library > Tools.  Visit http://steampowered.com to install Steam.");
				break;
			case HmdError.Driver_RuntimeOutOfDate:
				Debug.Log("SteamVR Initialization Failed!  Make sure device's runtime is up to date.");
				break;
			default:
				Debug.Log(OpenVR.GetStringForHmdError(error));
				break;
		}
	}

	// native interfaces
	public CVRSystem hmd { get; private set; }
	public CVRCompositor compositor { get; private set; }
	public CVROverlay overlay { get; private set; }

	// tracking status
	static public bool initializing { get; private set; }
	static public bool calibrating { get; private set; }
	static public bool outOfRange { get; private set; }

	static public bool[] connected = new bool[OpenVR.k_unMaxTrackedDeviceCount];

	// render values
	public float sceneWidth { get; private set; }
	public float sceneHeight { get; private set; }
	public float aspect { get; private set; }
	public float fieldOfView { get; private set; }
	public Vector2 tanHalfFov { get; private set; }
	public VRTextureBounds_t[] textureBounds { get; private set; }
	public SteamVR_Utils.RigidTransform[] eyes { get; private set; }
	public GraphicsAPIConvention graphicsAPI;

	// hmd properties
	public string hmd_TrackingSystemName { get { return GetStringProperty(TrackedDeviceProperty.Prop_TrackingSystemName_String); } }
	public string hmd_ModelNumber { get { return GetStringProperty(TrackedDeviceProperty.Prop_ModelNumber_String); } }
	public string hmd_SerialNumber { get { return GetStringProperty(TrackedDeviceProperty.Prop_SerialNumber_String); } }

	public float hmd_SecondsFromVsyncToPhotons { get { return GetFloatProperty(TrackedDeviceProperty.Prop_SecondsFromVsyncToPhotons_Float); } }
	public float hmd_DisplayFrequency { get { return GetFloatProperty(TrackedDeviceProperty.Prop_DisplayFrequency_Float); } }

	public string GetTrackedDeviceString(uint deviceId)
	{
		var error = TrackedPropertyError.TrackedProp_Success;
		var capacity = hmd.GetStringTrackedDeviceProperty(deviceId, TrackedDeviceProperty.Prop_AttachedDeviceId_String, null, 0, ref error);
		if (capacity > 1)
		{
			var result = new System.Text.StringBuilder((int)capacity);
			hmd.GetStringTrackedDeviceProperty(deviceId, TrackedDeviceProperty.Prop_AttachedDeviceId_String, result, capacity, ref error);
			return result.ToString();
		}
		return null;
	}

	string GetStringProperty(TrackedDeviceProperty prop)
	{
		var error = TrackedPropertyError.TrackedProp_Success;
		var capactiy = hmd.GetStringTrackedDeviceProperty(OpenVR.k_unTrackedDeviceIndex_Hmd, prop, null, 0, ref error);
		if (capactiy > 1)
		{
			var result = new System.Text.StringBuilder((int)capactiy);
			hmd.GetStringTrackedDeviceProperty(OpenVR.k_unTrackedDeviceIndex_Hmd, prop, result, capactiy, ref error);
			return result.ToString();
		}
		return (error != TrackedPropertyError.TrackedProp_Success) ? error.ToString() : "<unknown>";
	}

	float GetFloatProperty(TrackedDeviceProperty prop)
	{
		var error = TrackedPropertyError.TrackedProp_Success;
		return hmd.GetFloatTrackedDeviceProperty(OpenVR.k_unTrackedDeviceIndex_Hmd, prop, ref error);
	}

	#region Event callbacks

	private void OnInitializing(params object[] args)
	{
		initializing = (bool)args[0];
	}

	private void OnCalibrating(params object[] args)
	{
		calibrating = (bool)args[0];
	}

	private void OnOutOfRange(params object[] args)
	{
		outOfRange = (bool)args[0];
	}

	private void OnDeviceConnected(params object[] args)
	{
		var i = (int)args[0];
		connected[i] = (bool)args[1];
	}

	private void OnNewPoses(params object[] args)
	{
		var poses = (TrackedDevicePose_t[])args[0];

		// Update eye offsets to account for IPD changes.
		eyes[0] = new SteamVR_Utils.RigidTransform(hmd.GetEyeToHeadTransform(Hmd_Eye.Eye_Left));
		eyes[1] = new SteamVR_Utils.RigidTransform(hmd.GetEyeToHeadTransform(Hmd_Eye.Eye_Right));

		for (int i = 0; i < poses.Length; i++)
		{
			var connected = poses[i].bDeviceIsConnected;
			if (connected != SteamVR.connected[i])
			{
				SteamVR_Utils.Event.Send("device_connected", i, connected);
			}
		}

		if (poses.Length > OpenVR.k_unTrackedDeviceIndex_Hmd)
		{
			var result = poses[OpenVR.k_unTrackedDeviceIndex_Hmd].eTrackingResult;

			var initializing = result == HmdTrackingResult.TrackingResult_Uninitialized;
			if (initializing != SteamVR.initializing)
			{
				SteamVR_Utils.Event.Send("initializing", initializing);
			}

			var calibrating =
				result == HmdTrackingResult.TrackingResult_Calibrating_InProgress ||
				result == HmdTrackingResult.TrackingResult_Calibrating_OutOfRange;
			if (calibrating != SteamVR.calibrating)
			{
				SteamVR_Utils.Event.Send("calibrating", calibrating);
			}

			var outOfRange =
				result == HmdTrackingResult.TrackingResult_Running_OutOfRange ||
				result == HmdTrackingResult.TrackingResult_Calibrating_OutOfRange;
			if (outOfRange != SteamVR.outOfRange)
			{
				SteamVR_Utils.Event.Send("out_of_range", outOfRange);
			}
		}
	}

	#endregion

	private SteamVR(System.IntPtr pHmd, System.IntPtr pCompositor, System.IntPtr pOverlay)
	{
		hmd = new CVRSystem(pHmd);
		Debug.Log("Connected to " + hmd_TrackingSystemName + ":" + hmd_SerialNumber);

		compositor = new CVRCompositor(pCompositor);
		overlay = new CVROverlay(pOverlay);

		var capacity = compositor.GetLastError(null, 0);
		if (capacity > 1)
		{
			var result = new System.Text.StringBuilder((int)capacity);
			compositor.GetLastError(result, capacity);
			Debug.Log("Compositor - " + result);
		}

		// Setup render values
		uint w = 0, h = 0;
		hmd.GetRecommendedRenderTargetSize(ref w, ref h);
		sceneWidth = (float)w;
		sceneHeight = (float)h;

		float l_left = 0.0f, l_right = 0.0f, l_top = 0.0f, l_bottom = 0.0f;
		hmd.GetProjectionRaw(Hmd_Eye.Eye_Left, ref l_left, ref l_right, ref l_top, ref l_bottom);

		float r_left = 0.0f, r_right = 0.0f, r_top = 0.0f, r_bottom = 0.0f;
		hmd.GetProjectionRaw(Hmd_Eye.Eye_Right, ref r_left, ref r_right, ref r_top, ref r_bottom);

		tanHalfFov = new Vector2(
			Mathf.Max(-l_left, l_right, -r_left, r_right),
			Mathf.Max(-l_top, l_bottom, -r_top, r_bottom));

		textureBounds = new VRTextureBounds_t[2];

		textureBounds[0].uMin = 0.5f + 0.5f * l_left / tanHalfFov.x;
		textureBounds[0].uMax = 0.5f + 0.5f * l_right / tanHalfFov.x;
		textureBounds[0].vMin = 0.5f - 0.5f * l_bottom / tanHalfFov.y;
		textureBounds[0].vMax = 0.5f - 0.5f * l_top / tanHalfFov.y;

		textureBounds[1].uMin = 0.5f + 0.5f * r_left / tanHalfFov.x;
		textureBounds[1].uMax = 0.5f + 0.5f * r_right / tanHalfFov.x;
		textureBounds[1].vMin = 0.5f - 0.5f * r_bottom / tanHalfFov.y;
		textureBounds[1].vMax = 0.5f - 0.5f * r_top / tanHalfFov.y;

		Unity.SetSubmitParams(textureBounds[0], textureBounds[1], VRSubmitFlags_t.Submit_Default);

		// Grow the recommended size to account for the overlapping fov
		sceneWidth = sceneWidth / Mathf.Max(textureBounds[0].uMax - textureBounds[0].uMin, textureBounds[1].uMax - textureBounds[1].uMin);
		sceneHeight = sceneHeight / Mathf.Max(textureBounds[0].vMax - textureBounds[0].vMin, textureBounds[1].vMax - textureBounds[1].vMin);

		aspect = tanHalfFov.x / tanHalfFov.y;
		fieldOfView = 2.0f * Mathf.Atan(tanHalfFov.y) * Mathf.Rad2Deg;

		eyes = new SteamVR_Utils.RigidTransform[] {
			new SteamVR_Utils.RigidTransform(hmd.GetEyeToHeadTransform(Hmd_Eye.Eye_Left)),
			new SteamVR_Utils.RigidTransform(hmd.GetEyeToHeadTransform(Hmd_Eye.Eye_Right)) };

		if (SystemInfo.graphicsDeviceVersion.StartsWith("OpenGL"))
			graphicsAPI = GraphicsAPIConvention.API_OpenGL;
		else
			graphicsAPI = GraphicsAPIConvention.API_DirectX;

		SteamVR_Utils.Event.Listen("initializing", OnInitializing);
		SteamVR_Utils.Event.Listen("calibrating", OnCalibrating);
		SteamVR_Utils.Event.Listen("out_of_range", OnOutOfRange);
		SteamVR_Utils.Event.Listen("device_connected", OnDeviceConnected);
		SteamVR_Utils.Event.Listen("new_poses", OnNewPoses);
	}

	~SteamVR()
	{
		Dispose(false);
	}

	public void Dispose()
	{
		Dispose(true);
		System.GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		SteamVR_Utils.Event.Remove("initializing", OnInitializing);
		SteamVR_Utils.Event.Remove("calibrating", OnCalibrating);
		SteamVR_Utils.Event.Remove("out_of_range", OnOutOfRange);
		SteamVR_Utils.Event.Remove("device_connected", OnDeviceConnected);
		SteamVR_Utils.Event.Remove("new_poses", OnNewPoses);

		ShutdownSystems();
		_instance = null;
	}

	private static void ShutdownSystems()
	{
		OpenVR.Shutdown();
	}

	// Use this interface to avoid accidentally creating the instance in the process of attempting to dispose of it.
	public static void SafeDispose()
	{
		if (_instance != null)
			_instance.Dispose();
	}
}


//========= Copyright 2014, Valve Corporation, All rights reserved. ===========
//
// Purpose: Handles rendering of all SteamVR_Cameras
//
//=============================================================================

using UnityEngine;
using System.Collections;
using Valve.VR;

public class SteamVR_Render : MonoBehaviour
{
	public float helpSeconds = 10.0f;
	public string helpText = "You may now put on your headset.";
	public GUIStyle helpStyle;

	public LayerMask leftMask, rightMask;

	SteamVR_CameraMask cameraMask;

	public TrackingUniverseOrigin trackingSpace = TrackingUniverseOrigin.TrackingUniverseStanding;

	static public Hmd_Eye eye { get; private set; }

	static private SteamVR_Render _instance;
	static public SteamVR_Render instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = GameObject.FindObjectOfType<SteamVR_Render>();

				if (_instance == null)
					_instance = new GameObject("[SteamVR]").AddComponent<SteamVR_Render>();
			}
			return _instance;
		}
	}

	void OnDestroy()
	{
		_instance = null;
	}

	static private bool isQuitting;
	void OnApplicationQuit()
	{
		isQuitting = true;
		SteamVR.SafeDispose();
	}

	static public void Add(SteamVR_Camera vrcam)
	{
		if (!isQuitting)
			instance.AddInternal(vrcam);
	}

	static public void Remove(SteamVR_Camera vrcam)
	{
		if (!isQuitting && _instance != null)
			instance.RemoveInternal(vrcam);
	}

	static public SteamVR_Camera Top()
	{
		if (!isQuitting)
			return instance.TopInternal();

		return null;
	}

	private SteamVR_Camera[] cameras = new SteamVR_Camera[0];

	void AddInternal(SteamVR_Camera vrcam)
	{
		var camera = vrcam.GetComponent<Camera>();
		var length = cameras.Length;
		var sorted = new SteamVR_Camera[length + 1];
		int insert = 0;
		for (int i = 0; i < length; i++)
		{
			var c = cameras[i].GetComponent<Camera>();
			if (i == insert && c.depth > camera.depth)
				sorted[insert++] = vrcam;

			sorted[insert++] = cameras[i];
		}
		if (insert == length)
			sorted[insert] = vrcam;

		cameras = sorted;
	}

	void RemoveInternal(SteamVR_Camera vrcam)
	{
		var length = cameras.Length;
		int count = 0;
		for (int i = 0; i < length; i++)
		{
			var c = cameras[i];
			if (c == vrcam)
				++count;
		}
		if (count == 0)
			return;

		var sorted = new SteamVR_Camera[length - count];
		int insert = 0;
		for (int i = 0; i < length; i++)
		{
			var c = cameras[i];
			if (c != vrcam)
				sorted[insert++] = c;
		}

		cameras = sorted;
	}

	SteamVR_Camera TopInternal()
	{
		if (cameras.Length > 0)
			return cameras[cameras.Length - 1];

		return null;
	}

	private TrackedDevicePose_t[] poses = new TrackedDevicePose_t[OpenVR.k_unMaxTrackedDeviceCount];
	private TrackedDevicePose_t[] gamePoses = new TrackedDevicePose_t[0];

	private IEnumerator RenderLoop()
	{
		while (true)
		{
			yield return new WaitForEndOfFrame();

			var vr = SteamVR.instance;

			if (vr.compositor.CanRenderScene())
			{
				vr.compositor.SetTrackingSpace(trackingSpace);
				vr.compositor.WaitGetPoses(poses, gamePoses);
				SteamVR_Utils.Event.Send("new_poses", poses);
			}

			GL.IssuePluginEvent(20150313); // Fire off render event to perform our compositor sync
			SteamVR_Camera.GetSceneTexture(cameras[0].GetComponent<Camera>().hdr).GetNativeTexturePtr(); // flush render event

			var overlay = SteamVR_Overlay.instance;
			if (overlay != null)
				overlay.UpdateOverlay(vr);

			RenderEye(vr, Hmd_Eye.Eye_Left, leftMask);
			RenderEye(vr, Hmd_Eye.Eye_Right, rightMask);

			if (cameraMask != null)
				cameraMask.Clear();

			GL.IssuePluginEvent(20150213); // Fire off render event for in-process present hook
		}
	}

	void RenderEye(SteamVR vr, Hmd_Eye eye, LayerMask mask)
	{
		int i = (int)eye;
		SteamVR_Render.eye = eye;

		if (cameraMask != null)
			cameraMask.Set(vr, eye);

		foreach (var c in cameras)
		{
			c.transform.localPosition = vr.eyes[i].pos;
			c.transform.localRotation = vr.eyes[i].rot;

			// Update position to keep from getting culled
			cameraMask.transform.position = c.transform.position;

			var camera = c.GetComponent<Camera>();
			camera.targetTexture = SteamVR_Camera.GetSceneTexture(camera.hdr);
			int cullingMask = camera.cullingMask;
			camera.cullingMask |= mask;
			camera.Render();
			camera.cullingMask = cullingMask;
		}
	}

	void OnEnable()
	{
		StartCoroutine("RenderLoop");
	}

	void OnDisable()
	{
		StopAllCoroutines();
	}

	void Awake()
	{
		var go = new GameObject("cameraMask");
		go.transform.parent = transform;
		cameraMask = go.AddComponent<SteamVR_CameraMask>();
	}

	void Update()
	{
		if (cameras.Length == 0)
		{
			enabled = false;
			return;
		}

		// Force controller update in case no one else called this frame to ensure prevState gets updated.
		SteamVR_Controller.Update();

		// Ensure various settings to minimize latency.
		Application.targetFrameRate = -1;
		Application.runInBackground = true; // don't require companion window focus
		QualitySettings.maxQueuedFrames = 0;
		QualitySettings.vSyncCount = 0; // this applies to the companion window
	}

	void OnGUI()
	{
		var t = Time.timeSinceLevelLoad;
		if (t < helpSeconds)
		{
			var vr = SteamVR.instance;
			if (vr != null)
			{
				if (helpStyle == null)
				{
					helpStyle = new GUIStyle(GUI.skin.label);
					helpStyle.fontSize = 32;
				}

				if (t > helpSeconds - 1.0f)
				{
					var color = helpStyle.normal.textColor;
					color.a = helpSeconds - t;
					helpStyle.normal.textColor = color;
				}

				GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
				GUILayout.BeginVertical();
				GUILayout.FlexibleSpace();
				GUILayout.Label(helpText, helpStyle);
				GUILayout.EndVertical();
				GUILayout.EndArea();
			}
		}
	}

	static public void ShowHelpText(string text, float seconds)
	{
		if (_instance != null)
		{
			_instance.helpText = text;
			_instance.helpSeconds = Time.timeSinceLevelLoad + seconds;
		}
	}
}


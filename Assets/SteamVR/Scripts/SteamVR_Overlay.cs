//========= Copyright 2014, Valve Corporation, All rights reserved. ===========
//
// Purpose: Displays 2d content on a large virtual screen.
//
//=============================================================================

using UnityEngine;
using System.Collections;
using Valve.VR;

public class SteamVR_Overlay : MonoBehaviour
{
	public Texture texture;
	public bool curved = true;
	public bool antialias = true;
	public bool highquality = true;
	public float scale = 3.0f;			// size of overlay view
	public float distance = 1.25f;		// distance from surface
	public float alpha = 1.0f;			// opacity 0..1
	public float gamma = 1.0f;

	public Vector4 uvOffset = new Vector4(0, 0, 1, 1);
	public Vector2 mouseScale = new Vector2(1, 1);
	public Vector2 curvedRange = new Vector2(1, 2);

	public VROverlayInputMethod inputMethod = VROverlayInputMethod.None;

	static public SteamVR_Overlay instance { get; private set; }

	private string key { get { return "unity:" + Application.companyName + "." + Application.productName; } }
	private ulong handle = OpenVR.k_ulOverlayHandleInvalid;

	void OnEnable()
	{
		var vr = SteamVR.instance;
		if (vr != null && vr.overlay != null)
		{
			var error = vr.overlay.CreateOverlay(key, gameObject.name, ref handle);
			if (error != VROverlayError.None)
			{
				Debug.Log(vr.overlay.GetOverlayErrorNameFromEnum(error));
				enabled = false;
				return;
			}
		}

		SteamVR_Overlay.instance = this;
	}

	void OnDisable()
	{
		if (handle != OpenVR.k_ulOverlayHandleInvalid)
		{
			if (SteamVR.active)
			{
				var vr = SteamVR.instance;
				if (vr.overlay != null)
					vr.overlay.DestroyOverlay(handle);
			}

			handle = OpenVR.k_ulOverlayHandleInvalid;
		}

		SteamVR_Overlay.instance = null;
	}

	public void UpdateOverlay(SteamVR vr)
	{
		if (texture != null)
		{
			var error = vr.overlay.ShowOverlay(handle);
			if (error == VROverlayError.InvalidHandle || error == VROverlayError.UnknownOverlay)
			{
				if (vr.overlay.FindOverlay(key, ref handle) != VROverlayError.None)
					return;
			}

			vr.overlay.SetOverlayTexture(handle, vr.graphicsAPI, texture.GetNativeTexturePtr());
			vr.overlay.SetOverlayAlpha(handle, alpha);
			vr.overlay.SetOverlayGamma(handle, gamma);
			vr.overlay.SetOverlayWidthInMeters(handle, scale);
			vr.overlay.SetOverlayAutoCurveDistanceRangeInMeters(handle, curvedRange.x, curvedRange.y);

			var textureBounds = new VRTextureBounds_t();
			textureBounds.uMin = (0 + uvOffset.x) * uvOffset.z;
			textureBounds.vMin = (1 + uvOffset.y) * uvOffset.w;
			textureBounds.uMax = (1 + uvOffset.x) * uvOffset.z;
			textureBounds.vMax = (0 + uvOffset.y) * uvOffset.w;
			vr.overlay.SetOverlayTextureBounds(handle, ref textureBounds);

			var vecMouseScale = new HmdVector2_t();
			vecMouseScale.v = new float[] { mouseScale.x, mouseScale.y };
			vr.overlay.SetOverlayMouseScale(handle, ref vecMouseScale);

			var vrcam = SteamVR_Render.Top();
			if (vrcam != null && vrcam.origin != null)
			{
				var offset = new SteamVR_Utils.RigidTransform(vrcam.origin, transform);
				offset.pos.x /= vrcam.origin.localScale.x;
				offset.pos.y /= vrcam.origin.localScale.y;
				offset.pos.z /= vrcam.origin.localScale.z;

				offset.pos.z += distance;

				var t = offset.ToHmdMatrix34();
				vr.overlay.SetOverlayTransformAbsolute(handle, SteamVR_Render.instance.trackingSpace, ref t);
			}

			vr.overlay.SetOverlayInputMethod(handle, inputMethod);

			if (curved || antialias)
				highquality = true;

			if (highquality)
			{
				vr.overlay.SetHighQualityOverlay(handle);
				vr.overlay.SetOverlayFlag(handle, VROverlayFlags.Curved, curved);
				vr.overlay.SetOverlayFlag(handle, VROverlayFlags.RGSS4X, antialias);
			}
			else if (vr.overlay.GetHighQualityOverlay() == handle)
			{
				vr.overlay.SetHighQualityOverlay(OpenVR.k_ulOverlayHandleInvalid);
			}
		}
		else
		{
			vr.overlay.HideOverlay(handle);
		}
	}

	public bool PollNextEvent(ref VREvent_t pEvent)
	{
		var vr = SteamVR.instance;
		return vr.overlay.PollNextOverlayEvent(handle, ref pEvent);
	}

	public struct IntersectionResults
	{
		public Vector3 point;
		public Vector3 normal;
		public Vector2 UVs;
		public float distance;
	}

	public bool ComputeIntersection(Vector3 source, Vector3 direction, ref IntersectionResults results)
	{
		var vr = SteamVR.instance;

		var input = new VROverlayIntersectionParams_t();
		input.eOrigin = SteamVR_Render.instance.trackingSpace;
		input.vSource.v = new float[] { source.x, source.y, -source.z };
		input.vDirection.v = new float[] { direction.x, direction.y, -direction.z };

		var output = new VROverlayIntersectionResults_t();
		if (!vr.overlay.ComputeOverlayIntersection(handle, ref input, ref output))
			return false;

		results.point = new Vector3(output.vPoint.v[0], output.vPoint.v[1], -output.vPoint.v[2]);
		results.normal = new Vector3(output.vNormal.v[0], output.vNormal.v[1], -output.vNormal.v[2]);
		results.UVs = new Vector2(output.vUVs.v[0], output.vUVs.v[1]);
		results.distance = output.fDistance;
		return true;
	}
}


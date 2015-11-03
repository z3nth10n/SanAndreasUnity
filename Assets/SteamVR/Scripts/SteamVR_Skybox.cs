//========= Copyright 2015, Valve Corporation, All rights reserved. ===========
//
// Purpose: Sets cubemap to use in the compositor.
//
//=============================================================================

using UnityEngine;
using Valve.VR;

public class SteamVR_Skybox : MonoBehaviour
{
	// Note: Unity's Left and Right Skybox shader variables are switched.
	public Texture front, back, left, right, top, bottom;

	void OnEnable()
	{
		var vr = SteamVR.instance;
		if (vr != null && vr.compositor != null)
			vr.compositor.SetSkyboxOverride(GraphicsAPIConvention.API_DirectX,
				front ? front.GetNativeTexturePtr() : System.IntPtr.Zero,
				back ? back.GetNativeTexturePtr() : System.IntPtr.Zero,
				left ? left.GetNativeTexturePtr() : System.IntPtr.Zero,
				right ? right.GetNativeTexturePtr() : System.IntPtr.Zero,
				top ? top.GetNativeTexturePtr() : System.IntPtr.Zero,
				bottom ? bottom.GetNativeTexturePtr() : System.IntPtr.Zero);
	}

	void OnDisable()
	{
		if (SteamVR.active)
		{
			var vr = SteamVR.instance;
			if (vr.compositor != null)
				vr.compositor.ClearSkyboxOverride();
		}
	}
}


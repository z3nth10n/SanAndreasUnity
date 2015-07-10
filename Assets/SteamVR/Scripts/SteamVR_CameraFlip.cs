//========= Copyright 2015, Valve Corporation, All rights reserved. ===========
//
// Purpose: Flips the camera output back to normal for D3D.
//
//=============================================================================

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]
public class SteamVR_CameraFlip : MonoBehaviour
{
	static Material blitMaterial;

	new Camera camera;

	void OnEnable()
	{
		if (blitMaterial == null)
			blitMaterial = new Material(Shader.Find("Custom/SteamVR_BlitFlip"));

		camera = GetComponent<Camera>();
	}

	void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		var pass = (camera.hdr && QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0;
		Graphics.Blit(src, dest, blitMaterial, pass);
	}
}


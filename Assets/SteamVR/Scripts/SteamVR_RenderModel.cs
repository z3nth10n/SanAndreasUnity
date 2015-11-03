//========= Copyright 2014, Valve Corporation, All rights reserved. ===========
//
// Purpose: Render model of associated tracked object
//
//=============================================================================

using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using Valve.VR;

[ExecuteInEditMode, RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class SteamVR_RenderModel : MonoBehaviour
{
	public SteamVR_TrackedObject.EIndex index;
	public string modelOverride;

	// If someone knows how to keep these from getting cleaned up every time
	// you exit play mode, let me know.  I've tried marking the RenderModel
	// class below as [System.Serializable] and switching to normal public
	// variables for mesh and material to get them to serialize properly,
	// as well as tried marking the mesh and material objects as
	// DontUnloadUnusedAsset, but Unity was still unloading them.
	// The hashtable is preserving its entries, but the mesh and material
	// variables are going null.

	public class RenderModel
	{
		public RenderModel(Mesh mesh, Texture2D texture)
		{
			this.mesh = mesh;
			this.material = new Material(Shader.Find("Standard"));
			this.material.mainTexture = texture;
		}
		public Mesh mesh { get; private set; }
		public Material material { get; private set; }
	}

	public static Hashtable models = new Hashtable();

	private void OnDeviceConnected(params object[] args)
	{
		var i = (int)args[0];
		if (i != (int)index)
			return;

		var connected = (bool)args[1];
		if (connected)
		{
			UpdateModel();
		}
		else
		{
			GetComponent<MeshFilter>().mesh = null;
		}
	}

	public void UpdateModel()
	{
		var vr = SteamVR.instance;
		var error = TrackedPropertyError.TrackedProp_Success;
		var capactiy = vr.hmd.GetStringTrackedDeviceProperty((uint)index, TrackedDeviceProperty.Prop_RenderModelName_String, null, 0, ref error);
		if (capactiy <= 1)
		{
			Debug.LogError("Failed to get render model name for tracked object " + index);
			return;
		}

		var buffer = new System.Text.StringBuilder((int)capactiy);
		vr.hmd.GetStringTrackedDeviceProperty((uint)index, TrackedDeviceProperty.Prop_RenderModelName_String, buffer, capactiy, ref error);

		SetModel(buffer.ToString());
	}

	private void SetModel(string renderModelName)
	{
		var model = models[renderModelName] as RenderModel;
		if (model == null || model.mesh == null)
		{
			Debug.Log("Loading render model " + renderModelName);

			model = LoadRenderModel(renderModelName);
			if (model == null)
				return;

			models[renderModelName] = model;
		}

		GetComponent<MeshFilter>().mesh = model.mesh;
		GetComponent<MeshRenderer>().sharedMaterial = model.material;
	}

	static RenderModel LoadRenderModel(string renderModelName)
	{
		var error = HmdError.None;
		if (!SteamVR.active)
		{
			OpenVR.Init(ref error);
			if (error != HmdError.None)
				return null;
		}

		var pRenderModels = OpenVR.GetGenericInterface(OpenVR.IVRRenderModels_Version, ref error);
		if (pRenderModels == System.IntPtr.Zero || error != HmdError.None)
		{
			if (!SteamVR.active)
				OpenVR.Shutdown();
			return null;
		}

		var renderModels = new CVRRenderModels(pRenderModels);

		var renderModel = new RenderModel_t();
		if (!renderModels.LoadRenderModel(renderModelName, ref renderModel))
		{
			Debug.LogError("Failed to load render model " + renderModelName);

			if (!SteamVR.active)
				OpenVR.Shutdown();
			return null;
		}

		var vertices = new Vector3[renderModel.unVertexCount];
		var normals = new Vector3[renderModel.unVertexCount];
		var uv = new Vector2[renderModel.unVertexCount];

		var type = typeof(RenderModel_Vertex_t);
		for (int iVert = 0; iVert < renderModel.unVertexCount; iVert++)
		{
			var ptr = new System.IntPtr(renderModel.rVertexData.ToInt64() + iVert * Marshal.SizeOf(type));
			var vert = (RenderModel_Vertex_t)Marshal.PtrToStructure(ptr, type);

			vertices[iVert] = new Vector3(vert.vPosition.v[0], vert.vPosition.v[1], -vert.vPosition.v[2]);
			normals[iVert] = new Vector3(vert.vNormal.v[0], vert.vNormal.v[1], -vert.vNormal.v[2]);
			uv[iVert] = new Vector2(vert.rfTextureCoord[0], vert.rfTextureCoord[1]);
		}

		int indexCount = (int)renderModel.unTriangleCount * 3;
		var indices = new short[indexCount];
		Marshal.Copy(renderModel.rIndexData, indices, 0, indices.Length);

		var triangles = new int[indexCount];
		for (int iTri = 0; iTri < renderModel.unTriangleCount; iTri++)
		{
			triangles[iTri * 3 + 0] = (int)indices[iTri * 3 + 2];
			triangles[iTri * 3 + 1] = (int)indices[iTri * 3 + 1];
			triangles[iTri * 3 + 2] = (int)indices[iTri * 3 + 0];
		}

		var mesh = new Mesh();
		mesh.vertices = vertices;
		mesh.normals = normals;
		mesh.uv = uv;
		mesh.triangles = triangles;

		mesh.Optimize();
		//mesh.hideFlags = HideFlags.DontUnloadUnusedAsset;

		var textureMapData = new byte[renderModel.diffuseTexture.unWidth * renderModel.diffuseTexture.unHeight * 4]; // RGBA
		Marshal.Copy(renderModel.diffuseTexture.rubTextureMapData, textureMapData, 0, textureMapData.Length);

		var colors = new Color32[renderModel.diffuseTexture.unWidth * renderModel.diffuseTexture.unHeight];
		int iColor = 0;
		for (int iHeight = 0; iHeight < renderModel.diffuseTexture.unHeight; iHeight++)
		{
			for (int iWidth = 0; iWidth < renderModel.diffuseTexture.unWidth; iWidth++)
			{
				var r = textureMapData[iColor++];
				var g = textureMapData[iColor++];
				var b = textureMapData[iColor++];
				var a = textureMapData[iColor++];
				colors[iHeight * renderModel.diffuseTexture.unWidth + iWidth] = new Color32(r, g, b, a);
			}
		}

		var texture = new Texture2D(renderModel.diffuseTexture.unWidth, renderModel.diffuseTexture.unHeight, TextureFormat.ARGB32, true);
		texture.SetPixels32(colors);
		texture.Apply();

		//texture.hideFlags = HideFlags.DontUnloadUnusedAsset;

		renderModels.FreeRenderModel(ref renderModel);

		if (!SteamVR.active)
			OpenVR.Shutdown();

		return new RenderModel(mesh, texture);
	}

	void OnEnable()
	{
		// Make sure the mesh gets rendered.
		GetComponent<MeshRenderer>().enabled = true;

#if UNITY_EDITOR
		if (!Application.isPlaying)
			return;
#endif
		if (!string.IsNullOrEmpty(modelOverride))
		{
			Debug.Log("Model override is really only meant to be used in the scene view for lining things up; using it at runtime is discouraged.  Use tracked device index instead to ensure the correct model is displayed for all users.");
			enabled = false;
			return;
		}

		if (SteamVR.active)
		{
			var vr = SteamVR.instance;
			if (vr.hmd.IsTrackedDeviceConnected((uint)index))
				UpdateModel();
		}

		SteamVR_Utils.Event.Listen("device_connected", OnDeviceConnected);
	}

	void OnDisable()
	{
		// Also hide the mesh.
		GetComponent<MeshRenderer>().enabled = false;

#if UNITY_EDITOR
		if (!Application.isPlaying)
			return;
#endif
		SteamVR_Utils.Event.Remove("device_connected", OnDeviceConnected);
	}

#if UNITY_EDITOR
	void Update()
	{
		if (!Application.isPlaying && !string.IsNullOrEmpty(modelOverride))
			SetModel(modelOverride);
	}
#endif

	public void SetDeviceIndex(int index)
	{
		this.index = (SteamVR_TrackedObject.EIndex)index;
		modelOverride = "";
		UpdateModel();
	}
}


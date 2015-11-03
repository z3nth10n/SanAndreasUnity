//========= Copyright 2015, Valve Corporation, All rights reserved. ===========
//
// Purpose: Draws different sized room-scale play areas for targeting content
//
//=============================================================================

using UnityEngine;
using System.Collections;
using Valve.VR;

[ExecuteInEditMode, RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class SteamVR_PlayArea : MonoBehaviour
{
	public float borderThickness = 0.15f;
	public float wireframeHeight = 2.0f;
	public bool drawWireframeWhenSelectedOnly = false;
	public bool drawInGame = true;

	public enum Size
	{
		Calibrated,
		_400x300,
		_300x225,
		_200x150
	}

	public Size size;
	public Color color = Color.cyan;

	[HideInInspector]
	public Vector3[] vertices;

	public static bool GetBounds( Size size, ref HmdQuad_t pRect )
	{
		if (size == Size.Calibrated)
		{
			var error = HmdError.None;
			if (!SteamVR.active)
			{
				OpenVR.Init(ref error);
				if (error != HmdError.None)
					return false;
			}

			var pChaperone = OpenVR.GetGenericInterface(OpenVR.IVRChaperone_Version, ref error);
			if (pChaperone == System.IntPtr.Zero || error != HmdError.None)
			{
				if (!SteamVR.active)
					OpenVR.Shutdown();
				return false;
			}

			var chaperone = new CVRChaperone(pChaperone);

			bool success = chaperone.GetPlayAreaRect( ref pRect );
			if (!success)
				Debug.LogWarning("Failed to get Calibrated Play Area bounds!  Make sure you have tracking first, and that your space is calibrated.");

			if (!SteamVR.active)
				OpenVR.Shutdown();

			return success;
		}
		else
		{
			try
			{
				var str = size.ToString().Substring(1);
				var arr = str.Split(new char[] {'x'}, 2);
				// convert to half size in meters (from cm)
				var x = float.Parse(arr[0]) / 200;
				var z = float.Parse(arr[1]) / 200;
				pRect.vCorners = new HmdVector3_t[ 4 ];
				pRect.vCorners[ 0 ].v = new float[ 3 ] { x, 0, z };
				pRect.vCorners[ 1 ].v = new float[ 3 ] { x, 0, -z };
				pRect.vCorners[ 2 ].v = new float[ 3 ] { -x, 0, -z };
				pRect.vCorners[ 3 ].v = new float[ 3 ] { -x, 0, z };
				return true;
			}
			catch {}
		}

		return false;
	}

	public void BuildMesh()
	{
		var rect = new HmdQuad_t();
		if ( !GetBounds( size, ref rect ) )
			return;

		var corners = rect.vCorners;

		vertices = new Vector3[corners.Length * 2];
		for (int i = 0; i < corners.Length; i++)
		{
			var v = corners[i].v;
			vertices[i] = new Vector3(v[0], 0.01f, v[2]);
		}

		if (borderThickness == 0.0f)
		{
			GetComponent<MeshFilter>().mesh = null;
			return;
		}

		for (int i = 0; i < corners.Length; i++)
		{
			int next = (i + 1) % corners.Length;
			int prev = (i + corners.Length - 1) % corners.Length;

			var nextSegment = (vertices[next] - vertices[i]).normalized;
			var prevSegment = (vertices[prev] - vertices[i]).normalized;

			var vert = vertices[i];
			vert += Vector3.Cross(nextSegment, Vector3.up) * borderThickness;
			vert += Vector3.Cross(prevSegment, Vector3.down) * borderThickness;

			vertices[corners.Length + i] = vert;
		}

		var triangles = new int[]
		{
			0, 1, 4,
			1, 5, 4,
			1, 2, 5,
			2, 6, 5,
			2, 3, 6,
			3, 7, 6,
			3, 0, 7,
			0, 4, 7
		};

		var uv = new Vector2[]
		{
			new Vector2(0.0f, 0.0f),
			new Vector2(1.0f, 0.0f),
			new Vector2(0.0f, 0.0f),
			new Vector2(1.0f, 0.0f),
			new Vector2(0.0f, 1.0f),
			new Vector2(1.0f, 1.0f),
			new Vector2(0.0f, 1.0f),
			new Vector2(1.0f, 1.0f)
		};

		var colors = new Color[]
		{
			color,
			color,
			color,
			color,
			new Color(color.r, color.g, color.b, 0.0f),
			new Color(color.r, color.g, color.b, 0.0f),
			new Color(color.r, color.g, color.b, 0.0f),
			new Color(color.r, color.g, color.b, 0.0f)
		};

		var mesh = new Mesh();
		GetComponent<MeshFilter>().mesh = mesh;
		mesh.vertices = vertices;
		mesh.uv = uv;
		mesh.colors = colors;
		mesh.triangles = triangles;

		var renderer = GetComponent<MeshRenderer>();
		renderer.material = Resources.GetBuiltinResource<Material>("Sprites-Default.mat");
		renderer.reflectionProbeUsage = UnityEngine.Rendering.ReflectionProbeUsage.Off;
		renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
		renderer.receiveShadows = false;
		renderer.useLightProbes = false;
	}

#if UNITY_EDITOR
	Hashtable values;
	void Update()
	{
		if (!Application.isPlaying)
		{
			var fields = GetType().GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

			bool rebuild = false;

			if (values == null || (borderThickness != 0.0f && GetComponent<MeshFilter>().sharedMesh == null))
			{
				rebuild = true;
			}
			else
			{
				foreach (var f in fields)
				{
					if (!f.GetValue(this).Equals(values[f]))
					{
						rebuild = true;
						break;
					}
				}
			}

			if (rebuild)
			{
				BuildMesh();

				values = new Hashtable();
				foreach (var f in fields)
					values[f] = f.GetValue(this);
			}
		}
	}
#endif

	void OnDrawGizmos()
	{
		if (!drawWireframeWhenSelectedOnly)
			DrawWireframe();
	}

	void OnDrawGizmosSelected()
	{
		if (drawWireframeWhenSelectedOnly)
			DrawWireframe();
	}

	public void DrawWireframe()
	{
		if (vertices == null || vertices.Length == 0)
			return;

		var offset = transform.TransformVector(Vector3.up * wireframeHeight);
		for (int i = 0; i < 4; i++)
		{
			int next = (i + 1) % 4;

			var a = transform.TransformPoint(vertices[i]);
			var b = a + offset;
			var c = transform.TransformPoint(vertices[next]);
			var d = c + offset;
			Gizmos.DrawLine(a, b);
			Gizmos.DrawLine(a, c);
			Gizmos.DrawLine(b, d);
		}
	}

	public void OnEnable()
	{
		if (Application.isPlaying)
		{
			GetComponent<MeshRenderer>().enabled = drawInGame;

			// No need to remain enabled at runtime.
			// Anyone that wants to change properties at runtime
			// should call BuildMesh themselves.
			enabled = false;

			// If we want the configured bounds of the user,
			// we need to wait for tracking.
			if (drawInGame && size == Size.Calibrated)
				StartCoroutine("UpdateBounds");
		}
	}

	IEnumerator UpdateBounds()
	{
		GetComponent<MeshFilter>().mesh = null; // clear existing

		var vr = SteamVR.instance;
		if (vr == null)
			yield break;

		var error = HmdError.None;
		var pChaperone = OpenVR.GetGenericInterface(OpenVR.IVRChaperone_Version, ref error);
		if (pChaperone == System.IntPtr.Zero || error != HmdError.None)
			yield break;

		var chaperone = new CVRChaperone(pChaperone);
		while (chaperone.GetCalibrationState() != ChaperoneCalibrationState.OK)
			yield return null;

		BuildMesh();
	}
}


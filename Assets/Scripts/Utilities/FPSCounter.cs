using UnityEngine;
using SanAndreasUnity.Behaviours;

namespace SanAndreasUnity.Utilities {
	public class FPSCounter : MonoBehaviour {
		private static int fpsTextureWidth = 75;
		private static int fpsTextureHeight = 25;
		private static float fpsMaximum = 60.0f;
		private static float fpsGreen = 50.0f;
		private static float fpsYellow = 23.0f;
		private float fpsDeltaTime = 0.0f;
		private GUIGraph fpsGraph;

		void Start () {
			//fpsTexture = new Texture2D (fpsTextureWidth, fpsTextureHeight, TextureFormat.RGBA32, false, true);
			fpsGraph = new GUIGraph(fpsTextureWidth, fpsTextureHeight, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 0.0f, 0.0f, 1.0f), fpsMaximum);
			fpsGraph.addLimit (fpsGreen, new Color (0.0f, 1.0f, 0.0f, 1.0f));
			fpsGraph.addLimit (fpsYellow, new Color (1.0f, 1.0f, 0.0f, 1.0f));
		}

		void Update () {
			// FPS counting
			fpsDeltaTime += (Time.deltaTime - fpsDeltaTime) * 0.1f;
		}

		void OnGUI () {
			if (!Loader.HasLoaded) return;
			
			// Show FPS counter
			float msec = fpsDeltaTime * 1000.0f;
			float fps = 1.0f / fpsDeltaTime;
			GUILayout.BeginArea (new Rect (15 + fpsTextureWidth, Screen.height - 25, 100, 25));
			GUILayout.Label (string.Format("{0:0.}fps ({1:0.0}ms)", fps, msec));
			GUILayout.EndArea ();

			// Show FPS history
			fpsGraph.draw(new Vector2(5, Screen.height - fpsTextureHeight - 5), fps);
		}
	}
}

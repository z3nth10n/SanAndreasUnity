using UnityEngine;
using SanAndreasUnity.Behaviours;

namespace SanAndreasUnity.Utilities {
	public class FPSCounter : MonoBehaviour {
		private static int fpsTextureWidth = 75;
		private static int fpsTextureHeight = 25;
		private static float fpsMaximum = 60.0f;
		private static float fpsGreen = 50.0f;
		private static float fpsRed = 23.0f;
		private float fpsDeltaTime = 0.0f;
		private Texture2D fpsTexture = null;
		private float[] fpsHistory = new float[fpsTextureWidth];
		private int fpsIndex = 0;

		void Start () {
			fpsTexture = new Texture2D (fpsTextureWidth, fpsTextureHeight, TextureFormat.RGBA32, false, true);
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
			GUILayout.BeginArea (new Rect (15 + fpsTexture.width, Screen.height - 25, 100, 25));
			GUILayout.Label (string.Format("{0:0.}fps ({1:0.0}ms)", fps, msec));
			GUILayout.EndArea ();

			if (fpsTexture == null) return;

			// Show FPS history
			Color[] colors = new Color[fpsTexture.width * fpsTexture.height];
			Color cRed = new Color (1.0f, 0.0f, 0.0f, 1.0f);
			Color cYellow = new Color (1.0f, 1.0f, 0.0f, 1.0f);
			Color cGreen = new Color (0.0f, 1.0f, 0.0f, 1.0f);
			for (int i = 0; i < (fpsTexture.width * fpsTexture.height); i++) {
				colors [i] = new Color (0.0f, 0.0f, 0.0f, 0.66f); // Half-transparent background for FPS graph
			}
			fpsTexture.SetPixels (colors);
			// Append to history storage
			fpsHistory [fpsIndex] = fps;
			int f = fpsIndex;
			// Draw graph into texture
			for (int i = fpsTexture.width - 1; i >= 0; i--) {
				float graphVal = (fpsHistory [f] > fpsMaximum) ? fpsMaximum : fpsHistory [f];
				int height = (int)(graphVal * fpsTexture.height / (fpsMaximum + 0.1f));
				Color c = (fpsHistory[f] >= fpsGreen) ? cGreen : ((fpsHistory[f] <= fpsRed) ? cRed : cYellow);
				fpsTexture.SetPixel(i, height, c);
				f--;
				if (f < 0) {
					f = fpsHistory.Length - 1;
				}
			}
			// Next entry in rolling history buffer
			fpsIndex++;
			if (fpsIndex >= fpsHistory.Length) {
				fpsIndex = 0;
			}
			// Draw texture on GUI
			fpsTexture.Apply (false, false);
			GUI.DrawTexture (new Rect(5, Screen.height - fpsTexture.height - 5, fpsTexture.width, fpsTexture.height), fpsTexture);
		}
	}
}

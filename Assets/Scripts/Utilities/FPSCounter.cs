using UnityEngine;
using SanAndreasUnity.Behaviours;

namespace SanAndreasUnity.Utilities {
	public class FPSCounter : MonoBehaviour {
		private float fpsDeltaTime = 0.0f;
		private GUIGraph fpsGraph;

		public int textureWidth = 75;
		public int textureHeight = 25;

		public float screenPosX = 5;
		public float screenPosY = 5;
		public bool countPhysics = false;

		public float maximum = 60.0f;
		public float greenAbove = 50.0f;
		public float yellowAbove = 23.0f;

		void Start () {
			fpsGraph = new GUIGraph(textureWidth, textureHeight, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 0.0f, 0.0f, 1.0f), maximum);
			fpsGraph.addLimit (greenAbove, new Color (0.0f, 1.0f, 0.0f, 1.0f));
			fpsGraph.addLimit (yellowAbove, new Color (1.0f, 1.0f, 0.0f, 1.0f));
		}

		void Update () {
			// FPS counting
			if (!countPhysics)
				fpsDeltaTime += (Time.deltaTime - fpsDeltaTime) * 0.1f;
		}

		void FixedUpdate () {
			// Physics FPS counting
			if (countPhysics)
				fpsDeltaTime += (Time.fixedDeltaTime - fpsDeltaTime) * 0.1f;
		}

		void OnGUI () {
			if (!Loader.HasLoaded) return;
			
			// Show FPS counter
			float msec = fpsDeltaTime * 1000.0f;
			float fps = 1.0f / fpsDeltaTime;
			Rect r = new Rect (10 + textureWidth + screenPosX, screenPosY - 10, 100, 25);
			if (screenPosY < 0) r.y = Screen.height + screenPosY - 20;
			GUILayout.BeginArea (r);
			GUILayout.Label (string.Format("{0:0.}fps ({1:0.0}ms)", fps, msec));
			GUILayout.EndArea ();

			// Show FPS history
			Vector2 pos = new Vector2(screenPosX, screenPosY);
			if (screenPosY < 0) pos.y = Screen.height - textureHeight + screenPosY;
			fpsGraph.draw(pos, fps);
		}
	}
}

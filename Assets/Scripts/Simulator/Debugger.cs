/*
 * Originally from:
 * https://github.com/richardhannah/honours-project
 * 
 * More:
 * http://wordpress.richardhannah.ninja/honours-project/2014/11/06/simulation-progress-update/
 */
using UnityEngine;
using SanAndreasUnity.Behaviours;

namespace SanAndreasUnity.Simulator {
	public class Debugger : MonoBehaviour {
		static string debugLog;
		public Vector2 scrollPosition = new Vector2 (800, 10);

		void Start () {
			debugLog = ""; //"debugger output";
		}

		public static void Log(string message) {
			debugLog = message + "\n" + debugLog;
		}

		void OnGUI () {
			if (!Loader.HasLoaded) return;

			GUILayout.BeginArea (new Rect (800, 10, 400, 200));
			scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, false, GUILayout.Width(400), GUILayout.Height(200));
			GUILayout.Label(debugLog);
			GUILayout.EndScrollView();
			GUILayout.EndArea ();
		}
	}
}

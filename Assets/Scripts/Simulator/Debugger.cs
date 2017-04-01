/*
 * Originally from:
 * https://github.com/richardhannah/honours-project
 * 
 * More:
 * http://wordpress.richardhannah.ninja/honours-project/2014/11/06/simulation-progress-update/
 */
using UnityEngine;
using System.Collections;

namespace SanAndreasUnity.Simulator {
	public class Debugger : MonoBehaviour {
		static string debugLog;
		public Vector2 scrollPosition= new Vector2 (800, 10);

		void Start () {
			debugLog = "debugger output";
		}

		public static void Log(string message) {
			debugLog= "\n" + message + debugLog;
		}

		void OnGUI () {
			/*
			GUI.TextArea (new Rect (800, 10, 400, 200), debugLog);
			TextEditor editor = (TextEditor)GUIUtility.GetStateObject(typeof(TextEditor), GUIUtility.keyboardControl);
			editor.selectPos = debugLog.Length + 1;
			editor.pos = debugLog.Length + 1;
			*/

			GUILayout.BeginArea (new Rect (800, 10, 400, 200));
			scrollPosition = GUILayout.BeginScrollView(new Vector2(800,10),false,false, GUILayout.Width(400), GUILayout.Height(200));
			GUILayout.Label(debugLog);
			GUILayout.EndScrollView();
			GUILayout.EndArea ();
		}
	}

	/*
	class p {
		static var pDocument : String;
		static function log (string : String) {
			pDocument+="n"+string;
		}
	}
	function OnGUI () {
		myLog = GUI.TextArea (Rect (10, 10, Screen.width-10, Screen.height-10), p.pDocument);
	}
	*/
}

using UnityEngine;
using System.Collections;

public class Debugger : MonoBehaviour {

	static string debugLog;
	public Vector2 scrollPosition= new Vector2 (800, 10);
	public string longString = "This is a long-ish string";
	// Use this for initialization
	void Start () {
		debugLog = "debugger output";

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public static void Log(string message){

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

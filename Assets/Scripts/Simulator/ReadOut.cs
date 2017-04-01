using UnityEngine;
using System.Collections;

public class ReadOut : MonoBehaviour {


	public Transform transform;


	private float x;
	private float y;

	// Use this for initialization
	void Start () {
	
		x = transform.eulerAngles.x;
		y = transform.eulerAngles.y;

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI(){
		GUI.Label(new Rect(200, 10, 100, 20), "Euler Values");
		GUI.Label(new Rect(200, 30, 100, 20), "Roll X: " + x);
		GUI.Label(new Rect(200, 50, 100, 20), "Yaw Y: " + y);



		}
}

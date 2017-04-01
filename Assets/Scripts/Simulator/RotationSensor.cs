using UnityEngine;
using System.Collections;

public class RotationSensor : MonoBehaviour {



	private Quaternion currentRotation;

	// Use this for initialization
	void Start () {

		currentRotation = this.transform.parent.rigidbody.rotation;
	
	}
	
	// Update is called once per frame
	void Update () {
		currentRotation = this.transform.parent.rigidbody.rotation;
	}

	public Quaternion getRotation(){


		return currentRotation;
		}
}

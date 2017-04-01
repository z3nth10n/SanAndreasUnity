using UnityEngine;
using System.Collections;

public class DumbAttitudeControl : MonoBehaviour
{

		public Transform sensorModule;
		private Vector3 angularVelocity;
		private FlightControlScript flightController;


		// Use this for initialization
		void Start ()
		{
				angularVelocity = sensorModule.parent.rigidbody.angularVelocity;
				flightController = GetComponent<FlightControlScript> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
		angularVelocity = sensorModule.parent.rigidbody.angularVelocity;
		}

		void FixedUpdate (){

		AttitudeControl ();
		}

		private void AttitudeControl ()
		{	
				//errorQuaternion = desiredRotation - currentRotation;
		
		Debug.Log ("stabilising");
		
		
				if (angularVelocity.z < 0) {
			Debug.Log ("stabilising pitch");
						flightController.PitchB ();	
				} else if (angularVelocity.z > 0) {
						flightController.PitchF ();
			
				}
		
		
		
				if (angularVelocity.x < 0) {
						flightController.RollP ();
				} else if (angularVelocity.x > 0) {
						flightController.RollS ();  
				}
		
		
				if (angularVelocity.y > 0) {
						flightController.YawP ();	
				} else if (angularVelocity.y < 0) {
						flightController.YawS ();
				}
		}



}

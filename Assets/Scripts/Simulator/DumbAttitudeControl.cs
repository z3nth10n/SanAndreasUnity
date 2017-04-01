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
	public class DumbAttitudeControl : MonoBehaviour {
		public Transform sensorModule;
		private Vector3 angularVelocity;
		private FlightControlScript flightController;

		void Start () {
			angularVelocity = sensorModule.parent.GetComponent<Rigidbody>().angularVelocity;
			flightController = GetComponent<FlightControlScript> ();
		}

		void Update () {
			angularVelocity = sensorModule.parent.GetComponent<Rigidbody>().angularVelocity;
		}

		void FixedUpdate () {
			AttitudeControl ();
		}

		private void AttitudeControl () {	
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
}

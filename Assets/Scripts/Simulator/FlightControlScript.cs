/*
 * Originally from:
 * https://github.com/richardhannah/honours-project
 * 
 * More:
 * http://wordpress.richardhannah.ninja/honours-project/2014/11/06/simulation-progress-update/
 */
using UnityEngine;
using System.Collections;
using System;

namespace SanAndreasUnity.Simulator {
	public class FlightControlScript : MonoBehaviour {
		public Transform sensorModule;
		public Engine engine1;
		public Engine engine2;
		public Engine engine3;
		public Engine engine4;
		private float altitude;
		private Vector3 velocity;
		private Vector3 angularVelocity;
		private Quaternion desiredRotation;
		private Quaternion currentRotation;
		private Quaternion errorQuaternion;
		private float sensitivity;
		private float desiredAltitude;
		private float idleThrottle;

		float rollAngle;
		float yawAngle;
		float pitchAngle;

		void Start () {
			altitude = sensorModule.GetComponent<Altimeter> ().altitude;
			desiredRotation = new Quaternion (0, 0, 0, 1);
			currentRotation = sensorModule.GetComponent<RotationSensor> ().getRotation ();
			velocity = sensorModule.parent.GetComponent<Rigidbody>().velocity;
			angularVelocity = sensorModule.parent.GetComponent<Rigidbody>().angularVelocity;
			sensitivity = 0.5f;
			desiredAltitude = 0;
			idleThrottle = 15.9f;
			Idle ();

			rollAngle = 0;
			yawAngle = 0;
			pitchAngle = 0;
		}

		void Update () {
			//get readings from sensors
			altitude = sensorModule.GetComponent<Altimeter> ().altitude;
			currentRotation = sensorModule.GetComponent<RotationSensor> ().getRotation ();
			velocity = sensorModule.parent.GetComponent<Rigidbody>().velocity;
			angularVelocity = sensorModule.parent.GetComponent<Rigidbody>().angularVelocity;

			//Manual Control
			Quaternion moveVector = new Quaternion (0, 0, 0, 1);
			if (Input.GetAxis ("Pitch") > 0 ||
				Input.GetAxis ("Pitch") < 0 ||
				Input.GetAxis ("Roll") < 0 ||
				Input.GetAxis ("Roll") > 0 ||
				Input.GetAxis ("Yaw") < 0 ||
				Input.GetAxis ("Yaw") > 0 ||
				Input.GetAxis ("Elevate") > 0 ||
				Input.GetAxis ("Descend") > 0) {

				if (Input.GetAxis ("Pitch") > 0) {
					pitchAngle-= sensitivity;
				} else if (Input.GetAxis ("Pitch") < 0) {
					pitchAngle+=sensitivity;
				}

				if (Input.GetAxis ("Roll") > 0) {
					rollAngle-= sensitivity;
				} else if (Input.GetAxis ("Roll") < 0) {
					rollAngle+= sensitivity;
				}

				if (Input.GetAxis ("Yaw") > 0) {
					yawAngle+= sensitivity;
				} else if (Input.GetAxis ("Yaw") < 0) {
					yawAngle-= sensitivity;
				}

				if (Input.GetAxis ("Elevate") > 0) {
					//desiredAltitude++;
					//Debug.Log("input axis: " + Input.GetAxis ("Elevate").ToString());
					//Elevate ();
					GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().targetAltitude++;
				} else if (Input.GetAxis ("Descend") > 0) {
					//desiredAltitude--;
					Descend ();
					GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().targetAltitude--;
				}
			} else {
				rollAngle = 0;
				//yawAngle = 0;
				pitchAngle = 0;
			}

			moveVector = Quaternion.Euler(rollAngle,yawAngle,pitchAngle);
			GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().targetRot = moveVector;
		}

		void FixedUpdate () {
			//stabilise
			//dAttitudeControl ();
			//AltitudeControl ();
		}

		private void dAttitudeControl () {	
			//errorQuaternion = desiredRotation - currentRotation;

			Debug.Log ("stabilising");

			if (angularVelocity.z < 0) {
				PitchB ();	
			} else if (angularVelocity.z > 0) {
				PitchF ();
			}

			if (angularVelocity.x < 0) {
				RollP ();
			} else if (angularVelocity.x > 0) {
				RollS ();  
			}

			if (angularVelocity.y > 0) {
				YawP ();	
			} else if (angularVelocity.y < 0) {
				YawS ();
			}
		}

		private void AltitudeControl () {
			if (altitude < desiredAltitude) {
				if (velocity.y < 1) {
					Elevate ();
				} 
			}
		}

		public void Elevate () {
			engine1.IncreaseThrottle ();
			engine2.IncreaseThrottle ();
			engine3.IncreaseThrottle ();
			engine4.IncreaseThrottle ();
		}

		public void Descend () {
			engine1.DecreaseThrottle ();
			engine2.DecreaseThrottle ();
			engine3.DecreaseThrottle ();
			engine4.DecreaseThrottle ();
		}

		public void RollS () {
			engine4.IncreaseThrottle ();
			engine2.DecreaseThrottle ();

			//Debug.Log ("Roll axis: " + Input.GetAxis ("Roll"));
			//Vector3 force = transform.up * Math.Abs (Input.GetAxis ("Roll")) * sensitivity;
			//engine4.rigidbody.AddForce (force);
		}

		public void RollP () {
			engine2.IncreaseThrottle ();
			engine4.DecreaseThrottle ();

			//Debug.Log ("Roll axis: " + Input.GetAxis ("Roll"));
			//Vector3 force = transform.up * Math.Abs (Input.GetAxis ("Roll")) * sensitivity;
			//engine2.rigidbody.AddForce (force);
		}

		public void YawS () {
			engine2.DecreaseThrottle ();
			engine4.DecreaseThrottle ();
			engine1.IncreaseThrottle ();
			engine3.IncreaseThrottle ();

			/*
			Debug.Log ("Yaw axis: " + Input.GetAxis ("Yaw"));
			Vector3 rforce = transform.right * Math.Abs (Input.GetAxis ("Yaw")) * sensitivity;
			Vector3 lforce = -transform.right * Math.Abs (Input.GetAxis ("Yaw")) * sensitivity;
			engine2.rigidbody.AddForce (lforce);
			engine4.rigidbody.AddForce (rforce);
			*/
		}

		public void YawP () {
			engine2.IncreaseThrottle ();
			engine4.IncreaseThrottle ();
			engine1.DecreaseThrottle ();
			engine3.DecreaseThrottle ();

			/*
			Debug.Log ("Yaw axis: " + Input.GetAxis ("Yaw"));
			Vector3 rforce = -transform.right * Math.Abs (Input.GetAxis ("Yaw")) * sensitivity;
			Vector3 lforce = transform.right * Math.Abs (Input.GetAxis ("Yaw")) * sensitivity;
			engine2.rigidbody.AddForce (lforce);
			engine4.rigidbody.AddForce (rforce);
			*/
		}

		public void PitchF () {
			engine3.IncreaseThrottle ();
			engine1.DecreaseThrottle ();

			//Debug.Log ("Pitch axis: " + Input.GetAxis ("Pitch"));
			//Vector3 force = transform.up * Math.Abs (Input.GetAxis ("Pitch")) * sensitivity;
			//engine3.rigidbody.AddForce (force);
		}

		public void PitchB () {
			engine1.IncreaseThrottle ();
			engine3.DecreaseThrottle ();

			//Debug.Log ("Pitch axis: " + Input.GetAxis ("Pitch"));
			//Vector3 force = transform.up * Math.Abs (Input.GetAxis ("Pitch")) * sensitivity;
			//engine1.rigidbody.AddForce (force);
		}

		private void Idle () {
			engine1.SetThrottle (idleThrottle);
			engine2.SetThrottle (idleThrottle);
			engine3.SetThrottle (idleThrottle);
			engine4.SetThrottle (idleThrottle);
		}

		public float getDesAltitude () {
			return desiredAltitude;
		}

		public void Calibrate () {
			Debug.Log ("Calibrating");
			double liftoffval = CalibLiftOff ();
			Debug.Log (liftoffval);
		}

		private double CalibLiftOff () {
			double liftoffThrottle;
			desiredAltitude = 5;
			liftoffThrottle = engine1.getThrottle ();
			desiredAltitude = 0;
			return liftoffThrottle;
		}
	}
}

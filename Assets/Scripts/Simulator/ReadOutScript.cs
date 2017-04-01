using UnityEngine;
using System.Collections;
using System;

public class ReadOutScript : MonoBehaviour
{

		public Engine engine1;
		public Engine engine2;
		public Engine engine3;
		public Engine engine4;
		public Transform sensorModule;
		private Vector3 worldRot;
		private Quaternion sensorQ;
		private float altitude;
		private Vector3 velocity;
		private Vector3 angularVelocity;
		private bool viewToggle;
		private string upForceEditStr;
		private bool spacefighterToggle;
		private GameObject spacefighter;
		private int attControlSwitch;
		private string attControlString;


		// Use this for initialization
		void Start ()
		{
				viewToggle = false;
				spacefighterToggle = false;
				spacefighter = GameObject.Find ("omega_fighter");
				spacefighter.SetActive (false);




				worldRot = sensorModule.eulerAngles;
				sensorQ = sensorModule.rotation;
				altitude = sensorModule.GetComponent<Altimeter> ().altitude;
				velocity = sensorModule.parent.rigidbody.velocity;
				angularVelocity = sensorModule.parent.rigidbody.angularVelocity;
				upForceEditStr = "0";

				attControlSwitch = 0;
				attControlString = "none";

		}
	
		// Update is called once per frame
		void Update ()
		{

				worldRot = sensorModule.eulerAngles;
				sensorQ = sensorModule.rotation;
				altitude = sensorModule.GetComponent<Altimeter> ().altitude;
				velocity = sensorModule.parent.rigidbody.velocity;
				angularVelocity = sensorModule.parent.rigidbody.angularVelocity;
		}

		void OnGUI ()
		{

				//


				//switch to test object

				if (GUI.Button (new Rect (10, 120, 100, 30), "Switch Target")) {

						if (viewToggle == false) {

								Debug.Log ("Switching to companion Cube");
								//switch camera
								GameObject mainCam = GameObject.Find ("Main Camera");
								CamControl camContronl = mainCam.GetComponent<CamControl> ();
								camContronl.target = GameObject.Find ("CompanionCube").transform;


								//switch readouts
								this.sensorModule = GameObject.Find ("CubeSensor").transform;
								
								viewToggle = true;

						} else {
				
								Debug.Log ("Switching to quadcopter");
								GameObject mainCam = GameObject.Find ("Main Camera");
								CamControl camContronl = mainCam.GetComponent<CamControl> ();
								camContronl.target = GameObject.Find ("CameraFocus").transform;

								//switch readouts

								this.sensorModule = GameObject.Find ("Sensors").transform;

								viewToggle = false;
						}



				} 

				//reset scene

				if (GUI.Button (new Rect (10, 150, 100, 30), "Reset Sim")) {
						Application.LoadLevel ("quadcopter");
				}
				
				//add spacefighter model
				if (GUI.Button (new Rect (10, 180, 100, 30), "Spacefighter")) {

						if (spacefighterToggle == false) {

								spacefighter.SetActive (true);
								spacefighterToggle = true;

						} else {
								spacefighter.SetActive (false);
								spacefighterToggle = false;
						}
				}
				
				//calibrate idle thrust
				if (GUI.Button (new Rect (10, 210, 100, 30), "Calibrate")) {
			
						GameObject.Find ("FlightController").GetComponent<Calibrate> ().CalibLiftOff ();
				}
				
				//switch attitude control
				if (GUI.Button (new Rect (10, 240, 100, 30), "Att. Control")) {



						switch (attControlSwitch) {
						case 0:
								GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().enabled = true;
								attControlString = "PID";
								attControlSwitch++;
								break;
						case 1:
								GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().enabled = false;
								GameObject.Find ("FlightController").GetComponent<DumbAttitudeControl> ().enabled = true;
								attControlString = "dumb";
								attControlSwitch++;
								break;
						case 2:
								GameObject.Find ("FlightController").GetComponent<DumbAttitudeControl> ().enabled = false;
								attControlString = "none";
								attControlSwitch = 0;
								break;



						}
				}


				//Att control indicator
				GUI.Label (new Rect (120, 245, 100, 20), attControlString);
		
				//Engine thrust readouts
		
				GUI.Label (new Rect (10, 10, 100, 20), "Thrust Levels");
				GUI.Label (new Rect (10, 30, 100, 20), string.Format ("Engine 1: {0} %", Math.Round (engine1.getThrottle (), 2)));
				GUI.Label (new Rect (10, 50, 100, 20), string.Format ("Engine 2: {0} %", Math.Round (engine2.getThrottle (), 2)));
				GUI.Label (new Rect (10, 70, 100, 20), string.Format ("Engine 3: {0} %", Math.Round (engine3.getThrottle (), 2)));
				GUI.Label (new Rect (10, 90, 100, 20), string.Format ("Engine 4: {0} %", Math.Round (engine4.getThrottle (), 2)));


				//Attitude readouts

				//Quaternion Values
		
				GUI.Label (new Rect (120, 10, 100, 20), "Quaternion Values");
				GUI.Label (new Rect (120, 30, 100, 20), "X: " + sensorQ.x);
				GUI.Label (new Rect (120, 50, 100, 20), "Y: " + sensorQ.y);
				GUI.Label (new Rect (120, 70, 100, 20), "Z: " + sensorQ.z);
				GUI.Label (new Rect (120, 90, 100, 20), "W: " + sensorQ.w);

				//Euler Values - World

				GUI.Label (new Rect (220, 10, 100, 20), "World Euler Values");
				GUI.Label (new Rect (220, 30, 100, 20), "Roll: " + worldRot.x);
				GUI.Label (new Rect (220, 50, 100, 20), "Yaw: " + worldRot.y);
				GUI.Label (new Rect (220, 70, 100, 20), "Pitch: " + worldRot.z);


				//Quaternion Values
				
				GUI.Label (new Rect (10, 400, 100, 20), "target rotation");
		GUI.Label (new Rect (10, 420, 100, 20),string.Format("X: {0}", GameObject.Find("FlightController").GetComponent<AttitudeControl>().targetRot.x));
		GUI.Label (new Rect (10, 440, 100, 20), "Y: " + GameObject.Find("FlightController").GetComponent<AttitudeControl>().targetRot.y);
		GUI.Label (new Rect (10, 460, 100, 20), "Z: " + GameObject.Find("FlightController").GetComponent<AttitudeControl>().targetRot.z);
		GUI.Label (new Rect (10, 480, 100, 20), "W: " + GameObject.Find("FlightController").GetComponent<AttitudeControl>().targetRot.w);
						
						//Euler Values - World
						
		GUI.Label (new Rect (120, 400, 100, 20), " ");
		GUI.Label (new Rect (120, 420, 100, 20), "Roll: " + GameObject.Find("FlightController").GetComponent<AttitudeControl>().targetRot.eulerAngles.x);
		GUI.Label (new Rect (120, 440, 100, 20), "Yaw: " + GameObject.Find("FlightController").GetComponent<AttitudeControl>().targetRot.eulerAngles.y);
		GUI.Label (new Rect (120, 460, 100, 20), "Pitch: " + GameObject.Find("FlightController").GetComponent<AttitudeControl>().targetRot.eulerAngles.z);


				//Altitude readout


				GUI.Label (new Rect (320, 10, 100, 20), "Altitude");
				GUI.Label (new Rect (320, 30, 100, 20), altitude.ToString ());
				GUI.Label (new Rect (320, 50, 100, 20), "Desired Altitude");
				GUI.Label (new Rect (320, 70, 100, 20), GameObject.Find ("FlightController").transform.GetComponent<FlightControlScript> ().getDesAltitude ().ToString ());
				//Velocity readout


				GUI.Label (new Rect (420, 10, 100, 20), "Velocity");
				GUI.Label (new Rect (420, 30, 100, 20), "X:" + velocity.x);
				GUI.Label (new Rect (420, 50, 100, 20), "Y:" + velocity.y);
				GUI.Label (new Rect (420, 70, 100, 20), "Z:" + velocity.z);

				//Angular velocity

				GUI.Label (new Rect (520, 10, 100, 20), "Angular Velocity");
				GUI.Label (new Rect (520, 30, 100, 20), "X:" + angularVelocity.x);
				GUI.Label (new Rect (520, 50, 100, 20), "Y:" + angularVelocity.y);
				GUI.Label (new Rect (520, 70, 100, 20), "Z:" + angularVelocity.z);
				GUI.Label (new Rect (520, 90, 100, 20), "Magnitude:" + angularVelocity.magnitude);

				

				//PID Controller tuning

				GUI.Label (new Rect (800, 220, 200, 20), "Attitude Controller Tuning");
				GUI.Label (new Rect (800, 240, 200, 20), "Proportional");
				GUI.Label (new Rect (900, 240, 200, 20), string.Format ("{0}", Math.Round (GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().pGain, 2)));


				if (GUI.Button (new Rect (940, 240, 20, 20), "+")) {
					

						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().pGain += 0.1f;
					
					
					
				}
				
				if (GUI.Button (new Rect (960, 240, 20, 20), "-")) {
					
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().pGain -= 0.1f;
					
					
				}


				GUI.Label (new Rect (800, 260, 200, 20), "Integral");
				GUI.Label (new Rect (900, 260, 200, 20), string.Format ("{0}", Math.Round (GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().iGain, 2)));


				if (GUI.Button (new Rect (940, 260, 20, 20), "+")) {
			
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().iGain += 0.1f;
			
			
			
				}

				if (GUI.Button (new Rect (960, 260, 20, 20), "-")) {
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().iGain -= 0.1f;
			
			
				}
				GUI.Label (new Rect (800, 280, 200, 20), "Derivative");
				GUI.Label (new Rect (900, 280, 200, 20), string.Format ("{0}", Math.Round (GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain, 2)));


				if (GUI.Button (new Rect (940, 280, 20, 20), "+")) {

			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain += 0.1f;
			
			
			
				}

				if (GUI.Button (new Rect (960, 280, 20, 20), "-")) {
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain -= 0.1f;
			
			
				}

				if (GUI.Button (new Rect (940, 280, 20, 20), "+")) {
			
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain += 0.1f;
			
			
			
				}
		
				if (GUI.Button (new Rect (960, 280, 20, 20), "-")) {
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain -= 0.1f;
			
			
				}

				if (GUI.Button (new Rect (940, 300, 40, 20), "+1")) {
			
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain += 1f;
			
			
			
				}
		
				if (GUI.Button (new Rect (980, 300, 40, 20), "-1")) {
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain -= 1f;
			
			
				}

				if (GUI.Button (new Rect (940, 320, 60, 20), "+10")) {
			
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain += 10f;
			
			
			
				}
		
				if (GUI.Button (new Rect (1000, 320, 60, 20), "-10")) {
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain -= 10f;
			
			
				}

				if (GUI.Button (new Rect (940, 340, 80, 20), "+100")) {
			
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain += 100f;
			
			
			
				}
		
				if (GUI.Button (new Rect (1020, 340, 80, 20), "-100")) {
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain -= 100f;
			
			
				}

				if (GUI.Button (new Rect (940, 360, 100, 20), "+1000")) {
			
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain += 1000f;
			
			
			
				}
		
				if (GUI.Button (new Rect (1040, 360, 100, 20), "-1000")) {
			
						GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().dGain -= 1000f;
			
			
				}


		//Altitude Controller tuning
		
		GUI.Label (new Rect (800, 400, 200, 20), "Altitude Controller Tuning");
		GUI.Label (new Rect (800, 420, 200, 20), "Proportional");
		GUI.Label (new Rect (900, 420, 200, 20), string.Format ("{0}", Math.Round (GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().aPGain, 4)));
		
		
		if (GUI.Button (new Rect (940, 420, 20, 20), "+")) {
			
			
			GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().aPGain += 1f;
			
			
			
		}
		
		if (GUI.Button (new Rect (960, 420, 20, 20), "-")) {
			
			GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().aPGain -= 1f;
			
			
		}
		
		
		GUI.Label (new Rect (800, 440, 200, 20), "Integral");
		GUI.Label (new Rect (900, 440, 200, 20), string.Format ("{0}", Math.Round (GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().aIGain, 4)));
		
		
		if (GUI.Button (new Rect (940, 440, 20, 20), "+")) {
			
			
			GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().aIGain += 1f;
			
			
			
		}
		
		if (GUI.Button (new Rect (960, 440, 20, 20), "-")) {
			
			GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().aIGain -= 1f;
			
			
		}
		GUI.Label (new Rect (800, 460, 200, 20), "Derivative");
		GUI.Label (new Rect (900, 460, 200, 20), string.Format ("{0}", Math.Round (GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().aDGain, 4)));
		
		
		if (GUI.Button (new Rect (940, 460, 20, 20), "+")) {
			
			
			GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().aDGain += 1f;
			
			
			
		}
		
		if (GUI.Button (new Rect (960, 460, 20, 20), "-")) {
			
			GameObject.Find ("FlightController").GetComponent<AttitudeControl> ().aDGain -= 1f;
			
			
		}
		


				/*Companion Cube Readouts
				

				GameObject compCube = GameObject.Find ("CompanionCube");
				


				GUI.Label (new Rect (800, 10, 100, 20), "Companion Cube Readouts");
				GUI.Label (new Rect (800, 30, 100, 20), "Up Force:" + compCube.GetComponent<TestEngine> ().upForce);
				upForceEditStr = GUI.TextField (new Rect (800, 50, 100, 20), upForceEditStr, 25);
				if (GUI.Button (new Rect (900, 50, 20, 20), "+")) {

						double forceFromText = Convert.ToDouble (upForceEditStr);
						compCube.GetComponent<TestEngine> ().upForce += (float)forceFromText;
						

						

				}

				if (GUI.Button (new Rect (920, 50, 20, 20), "-")) {
						
						double forceFromText = Convert.ToDouble (upForceEditStr);
						compCube.GetComponent<TestEngine> ().upForce -= (float)forceFromText;
					
					
				}
				GUI.Label (new Rect (800, 70, 100, 20), "");
				GUI.Label (new Rect (800, 90, 100, 20), "");
				*/
	
		}

		void FixedUpdate ()
		{

		
		
		
		}
}

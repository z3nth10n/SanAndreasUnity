using UnityEngine;
using System.Collections;

public class Calibrate : MonoBehaviour
{


		public Transform sensorModule;
		public Engine engine1;
		public Engine engine2;
		public Engine engine3;
		public Engine engine4;
		private bool CalibLiftOffToggle;
		private GameObject quad;


		// Use this for initialization
		void Start ()
		{
				CalibLiftOffToggle = false;
		quad = GameObject.Find ("QuadCopter");
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void FixedUpdate ()
		{

				if (CalibLiftOffToggle == true) {


						engine1.IncreaseThrottle ();
						engine2.IncreaseThrottle ();
						engine3.IncreaseThrottle ();
						engine4.IncreaseThrottle ();

						if (sensorModule.parent.rigidbody.velocity.y > 0.01) {
								Debug.Log (engine1.getThrottle ());
								CalibLiftOffToggle = false;
								CutEngines ();
						}

				} else {
						CalibLiftOffToggle = false;			
						//CutEngines ();
				}


		}

		public void CalibLiftOff ()
		{
		
				if (CalibLiftOffToggle == false) {
						CalibLiftOffToggle = true;
				} else {
						CalibLiftOffToggle = false;
				}

		}

		private void CutEngines ()
		{
				engine1.CutEngine ();
				engine2.CutEngine ();
				engine3.CutEngine ();
				engine4.CutEngine ();
		}
}

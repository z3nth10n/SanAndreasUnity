using UnityEngine;
/*
 * Originally from:
 * https://github.com/richardhannah/honours-project
 * 
 * More:
 * http://wordpress.richardhannah.ninja/honours-project/2014/11/06/simulation-progress-update/
 */
using System.Collections;

namespace SanAndreasUnity.Simulator {
	public class Calibrate : MonoBehaviour {
		public Transform sensorModule;
		public Engine engine1;
		public Engine engine2;
		public Engine engine3;
		public Engine engine4;
		private bool CalibLiftOffToggle;
		private GameObject quad;

		void Start () {
			CalibLiftOffToggle = false;
			quad = GameObject.Find ("QuadCopter");
		}

		void FixedUpdate () {
			if (CalibLiftOffToggle == true) {
				engine1.IncreaseThrottle ();
				engine2.IncreaseThrottle ();
				engine3.IncreaseThrottle ();
				engine4.IncreaseThrottle ();

				if (sensorModule.parent.GetComponent<Rigidbody>().velocity.y > 0.01) {
					Debug.Log (engine1.getThrottle ());
					CalibLiftOffToggle = false;
					CutEngines ();
				}

			} else {
				CalibLiftOffToggle = false;			
				//CutEngines ();
			}
		}

		public void CalibLiftOff () {
			if (CalibLiftOffToggle == false) {
				CalibLiftOffToggle = true;
			} else {
				CalibLiftOffToggle = false;
			}
		}

		private void CutEngines () {
			engine1.CutEngine ();
			engine2.CutEngine ();
			engine3.CutEngine ();
			engine4.CutEngine ();
		}
	}
}

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
	public class Engine : MonoBehaviour {
		public float maxPower;
		public float throttle;
		public int engNum;

		void FixedUpdate () {
			Vector3 force = transform.up * (maxPower * (throttle / 100));
			GetComponent<Rigidbody>().AddForce (force);

			Vector3 torque = new Vector3 ();
			switch (engNum) {
			case 1:
				torque = transform.forward * (maxPower * (throttle / 100) * -1);
				break;

			case 2:
				torque = transform.right * (maxPower * (throttle / 100));
				break;

			case 3:
				torque = transform.forward * (maxPower * (throttle / 100));
				break;

			case 4:
				torque = transform.right * (maxPower * (throttle / 100) * -1);
				break;
			}

			GetComponent<Rigidbody>().AddForce (torque);
		}

		public void IncreaseThrottle () {
			if (throttle < 100.0f) {
				throttle=throttle + 0.1f;
			}
		}
		
		public void DecreaseThrottle () {
			if (throttle > 0.0f) {
				throttle = throttle - 0.1f;
			} else {
				throttle = 0.0f;
			}
		}

		public void CutEngine() {
			throttle = 0.0f;
		}

		public void SetThrottle(float value) {
			if ((value >= 0.0f) && (value <= 100.0f)) {
				throttle = value;
			}
		}

		public float getThrottle () {
			//double roundThrt = Math.Round (Convert.ToDouble(throttle), 2);
			return throttle;
		}
	}
}

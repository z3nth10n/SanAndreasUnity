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
			float power = maxPower * (throttle / 100);
			Vector3 force = transform.parent.up * power;

			Vector3 torque = new Vector3 ();
			switch (engNum) {
				case 1:
					torque = transform.right * power;
					break;

				case 2:
					torque = transform.forward * power;
					break;

				case 3:
					torque = transform.right * -power;
					break;

				case 4:
					torque = transform.forward * -power;
					break;
			}

			transform.parent.GetComponent<Rigidbody> ().AddForceAtPosition (force, transform.position);
			transform.parent.GetComponent<Rigidbody> ().AddForceAtPosition (torque / 10.0f, transform.position);
		}

		public void SetThrottle (float value) {
			if ((value >= 0.0f) && (value <= 100.0f)) {
				throttle = value;
			}
		}

		public float getThrottle () {
			return throttle;
		}
	}
}

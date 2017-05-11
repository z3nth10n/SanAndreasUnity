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

		private Vector3 getForce () {
			float power = maxPower * (throttle / 100.0f);
			Vector3 force = transform.up * power;
			return force * Time.fixedDeltaTime;
		}

		private Vector3 getTorque () {
			float power = maxPower * (throttle / 100.0f);

			Vector3 torque = new Vector3 ();
			switch (engNum) {
			case 1:
			case 3:
				torque = transform.up * power;
				break;

			case 2:
			case 4:
				torque = transform.up * -power;
				break;
			}
			return torque * Time.fixedDeltaTime * 0.1f;
		}

	#if UNITY_EDITOR
		void Update () {
			Vector3 force = getForce ();
			Debug.DrawRay(transform.position, force, Color.green, 0.5f);
		}
	#endif

		void FixedUpdate () {
			Vector3 force = getForce ();
			Vector3 torque = getTorque ();

			Rigidbody rb = transform.parent.GetComponent<Rigidbody> ();
			rb.AddForceAtPosition (force, transform.position);
			rb.AddTorque (torque);

			if (rb.useGravity) {
				Vector3 gravity = new Vector3 (0.0f, -9.81f * transform.parent.GetComponentInChildren<AttitudeControl> ().additionalGravity * Time.fixedDeltaTime, 0.0f);
				rb.AddForceAtPosition (gravity, transform.position);
			}
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

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
	public class RotationSensor : MonoBehaviour {
		private Vector3 currentRotationSpeed;
		private Rigidbody rb;

		void Start () {
			rb = this.transform.parent.GetComponent<Rigidbody> ();
			currentRotationSpeed = this.transform.InverseTransformDirection(rb.angularVelocity);
			currentRotationSpeed.x = -currentRotationSpeed.x;
			currentRotationSpeed.y = -currentRotationSpeed.y;
		}

		void FixedUpdate () {
			currentRotationSpeed = this.transform.InverseTransformDirection(rb.angularVelocity);
			currentRotationSpeed.x = -currentRotationSpeed.x;
			currentRotationSpeed.y = -currentRotationSpeed.y;
		}

		public Vector3 getRotationSpeed() {
			return currentRotationSpeed;
		}
	}
}

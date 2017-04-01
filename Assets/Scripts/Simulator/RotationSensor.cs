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
		private Quaternion currentRotation;

		void Start () {
			currentRotation = this.transform.parent.GetComponent<Rigidbody>().rotation;
		}

		void Update () {
			currentRotation = this.transform.parent.GetComponent<Rigidbody>().rotation;
		}

		public Quaternion getRotation() {
			return currentRotation;
		}
	}
}

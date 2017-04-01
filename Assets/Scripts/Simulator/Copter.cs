using UnityEngine;
using SanAndreasUnity.Behaviours;

namespace SanAndreasUnity.Simulator {
	public class Copter : MonoBehaviour {
		private bool isEnabled = false;

		void Update () {
			if ((!isEnabled) && Loader.HasLoaded) {
				isEnabled = true;

				// Place copter above world and enable gravity (so it doesn't fall while loading)
				GameObject quad = GameObject.Find ("QuadCopter");
				Vector2 p = quad.transform.position;
				p.y = 40.0f;
				quad.transform.position = p;
				quad.GetComponent<Rigidbody> ().useGravity = true;
				Rigidbody[] rbs = quad.GetComponentsInChildren<Rigidbody> ();
				foreach (Rigidbody rb in rbs) {
					rb.useGravity = true;
				}
			}
		}
	}
}

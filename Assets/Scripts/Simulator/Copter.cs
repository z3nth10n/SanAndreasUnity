using UnityEngine;
using SanAndreasUnity.Behaviours;

namespace SanAndreasUnity.Simulator {
	public class Copter : MonoBehaviour {
		private bool isEnabled = false;
		GameObject quad;

		void Update () {
			if (!Loader.HasLoaded) return;
			
			if (!isEnabled) {
				isEnabled = true;

				// Place copter above world and enable gravity (so it doesn't fall while loading)
				quad = GameObject.Find ("QuadCopter");
				Vector2 p = quad.transform.position;
				p.y = 40.0f;
				quad.transform.position = p;
				quad.GetComponent<Rigidbody> ().useGravity = true;
				Rigidbody[] rbs = quad.GetComponentsInChildren<Rigidbody> ();
				foreach (Rigidbody rb in rbs) {
					rb.useGravity = true;
				}
			}

			// Reset to a valid (and solid!) start position when falling below the world
			if (quad.transform.position.y < -300) {
				Transform spawn = GameObject.Find ("Player Spawns").GetComponentsInChildren<Transform> () [1];
				quad.transform.position = spawn.position;
				quad.transform.rotation = spawn.rotation;
			}

			// Constrain to stay inside map
			if (quad.transform.position.x < -3000) {
				var t = quad.transform.position;
				t.x = -3000;
				quad.transform.position = t;
			}
			if (quad.transform.position.x > 3000) {
				var t = quad.transform.position;
				t.x = 3000;
				quad.transform.position = t;
			}
			if (quad.transform.position.z < -3000) {
				var t = quad.transform.position;
				t.z = -3000;
				quad.transform.position = t;
			}
			if (quad.transform.position.z > 3000) {
				var t = quad.transform.position;
				t.z = 3000;
				quad.transform.position = t;
			}
		}
	}
}

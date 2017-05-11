using UnityEngine;
using SanAndreasUnity.Behaviours;

namespace SanAndreasUnity.Simulator {
	public class Copter : MonoBehaviour {
		private bool isEnabled = false;
		GameObject quad;

		private static float maxVelocity = 100.0f;
		private float maxVelocitySquared = maxVelocity * maxVelocity;

		private float initialHeight = 10.0f;
		private float maxScanHeight = 100.0f * 1000.0f;

		void OnGUI () {
			if (!Loader.HasLoaded) return;

			GUILayout.BeginArea (new Rect (Screen.width - 90, 10, 80, 40));
			if (GUILayout.Button ("Reset Quad")) {
				// Raycast to determine terrain height at current position
				// !! For this to work, the quadcopter has to be part of the "Ignore Raycast" Layer !!
				Vector3 positionHigh = quad.transform.position;
				positionHigh.y = maxScanHeight; // scan from 'high up' for the highest point of the terrain at this spot
				RaycastHit hit;
				if (Physics.Raycast (positionHigh, -Vector3.up, out hit)) {
					// Place copter a bit above the detected terrain
					positionHigh.y = maxScanHeight - hit.distance + initialHeight;
					quad.transform.position = positionHigh;
					quad.transform.rotation = new Quaternion (0, 0, 0, 1);
					quad.GetComponent<Rigidbody> ().velocity = Vector3.zero;
					quad.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
					quad.GetComponentInChildren<AttitudeControl> ().ResetPID ();
				}
			}
			GUILayout.EndArea ();
		}

		void FixedUpdate () {
			if (!Loader.HasLoaded) return;

			// Limit top-speed of quadcopter
			Rigidbody rb = quad.GetComponent<Rigidbody> ();
			if (rb.velocity.sqrMagnitude > maxVelocitySquared) {
				rb.velocity = rb.velocity.normalized * maxVelocity;
			}
		}

		void Update () {
			if (!Loader.HasLoaded) return;
			
			if (!isEnabled) {
				isEnabled = true;

				// Place copter above world and enable gravity (so it doesn't fall while loading)
				quad = GameObject.Find ("QuadCopter");
				quad.transform.position = new Vector3 (0, initialHeight, 0);
				quad.GetComponent<Rigidbody> ().useGravity = true;
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

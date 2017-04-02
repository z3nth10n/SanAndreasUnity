/*
 * Originally from:
 * https://github.com/richardhannah/honours-project
 * 
 * More:
 * http://wordpress.richardhannah.ninja/honours-project/2014/11/06/simulation-progress-update/
 */
using UnityEngine;

namespace SanAndreasUnity.Simulator {
	public class Altimeter : MonoBehaviour {
	    public float altitude;
		private RaycastHit hit;

		void Update () {
			if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
				altitude = hit.distance;
			}

			Debug.DrawRay(transform.position, -Vector3.up, Color.red);
		}
	}
}

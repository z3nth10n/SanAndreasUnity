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
	public class ReadOut : MonoBehaviour {
		public Transform transform;
		private float x;
		private float y;

		void Start () {
			x = transform.eulerAngles.x;
			y = transform.eulerAngles.y;

		}

		void OnGUI() {
			GUI.Label(new Rect(200, 10, 100, 20), "Euler Values");
			GUI.Label(new Rect(200, 30, 100, 20), "Roll X: " + x);
			GUI.Label(new Rect(200, 50, 100, 20), "Yaw Y: " + y);
		}
	}
}

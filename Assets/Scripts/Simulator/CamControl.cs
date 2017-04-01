using UnityEngine;
using System.Collections;

public class CamControl : MonoBehaviour
{

		public Transform target;//the target object
		public float hSpeedMod;//a speed modifier
		public float vSpeedMod;
		private Vector3 point;//the coord to the point where the camera looks at
		private float hAxis;
		private float vAxis;
		private float camDist;
		private bool fixCamToggle;
		private Vector3 camPoint;

		void Start ()
		{//Set up things on the start method
				camPoint = target.position;
				camDist = 20;
				point = target.transform.position;//get target's coords
				transform.LookAt (point);//makes the camera look to it
				hAxis = 0;


				hSpeedMod = 40;
				vSpeedMod = 20;


				fixCamToggle = false;
		}

		void Update ()
		{//makes the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
			


				if (Input.GetAxis ("FixCam") > 0) {
						if (fixCamToggle == false) {
								fixCamToggle = true;
						} else {
								fixCamToggle = false;
						}
				} else {
				}

				if (fixCamToggle == true) {

			//transform.position = new Vector3(target.position.x-20,target.position.y+10,target.position.z);
			Vector3 offset = new Vector3(-20,10,0);
			Vector3 quadheading = target.right;
			camPoint = target.position - 20 * quadheading.normalized;
			this.transform.position = camPoint;
			transform.LookAt(target);


				} else {
						point = target.transform.position;
						if (Input.GetAxis ("Fire3") > 0) {
								hAxis = Input.GetAxis ("Mouse X");
								vAxis = Input.GetAxis ("Mouse Y");
						}
						camDist -= Input.GetAxis ("Mouse ScrollWheel") * 10;
						transform.RotateAround (point, new Vector3 (0.0f, hAxis, 0.0f), Time.deltaTime * hSpeedMod);
						transform.Translate (Vector3.up * vAxis * Time.deltaTime * vSpeedMod, Space.World);
						transform.LookAt (point);

						//float dist = Vector3.Distance (this.transform.position, camPoint);


						Vector3 camHeading = this.transform.position - target.position;
				
						camPoint = target.position + camDist * camHeading.normalized;

						this.transform.position = Vector3.Lerp (this.transform.position, camPoint, Time.deltaTime * 1.0f);
				}
				
		}
}

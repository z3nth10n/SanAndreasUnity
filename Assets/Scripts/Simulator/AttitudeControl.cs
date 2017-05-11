/*
 * Originally from:
 * https://github.com/richardhannah/honours-project
 * 
 * More:
 * http://wordpress.richardhannah.ninja/honours-project/2014/11/06/simulation-progress-update/
 */
using UnityEngine;
using SanAndreasUnity.Behaviours;
using SanAndreasUnity.Utilities;

namespace SanAndreasUnity.Simulator {
	public class AttitudeControl : MonoBehaviour {
		public Engine engine1;
		public Engine engine2;
		public Engine engine3;
		public Engine engine4;

		// throttle constraints
		public float throtMax;
		public float throtMin;
		public float maxAngularSpeed;
		public float additionalGravity;

		// tunings
		public float pGain; // the proportional gain
		public float iGain; // the integral gain
		public float dGain; // the derivative gain

		// integrals
		private float integralX;
		private float integralY;
		private float integralZ;

		private Vector3 lastError;

		private GUIGraph graphRotX, graphRotY, graphRotZ;
		private GUIGraph graphMotor1, graphMotor2, graphMotor3, graphMotor4;
		private GUIGraph graphPidX, graphPidY, graphPidZ;
		private int graphWidth = 80;

		private float m1, m2, m3, m4;

		private float pidOutputX;
		private float pidOutputY;
		private float pidOutputZ;

		public void ResetPID() {
			lastError = new Vector3 (0, 0, 0);

			integralX = 0.0f;
			integralY = 0.0f;
			integralZ = 0.0f;
		}

		void Start () {
			pGain = 2.5f;
			iGain = 0.0f;
			dGain = 0.0f;

			throtMax = 100.0f;
			throtMin = 0.0f;

			maxAngularSpeed = 66.0f;
			additionalGravity = 9.81f;

			ResetPID ();

			graphRotX = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), 100.0f, -100.0f);
			graphRotY = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), 100.0f, -100.0f);
			graphRotZ = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), 100.0f, -100.0f);

			graphMotor1 = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), throtMax, throtMin);
			graphMotor2 = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), throtMax, throtMin);
			graphMotor3 = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), throtMax, throtMin);
			graphMotor4 = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), throtMax, throtMin);

			graphPidX = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), throtMax, -throtMax);
			graphPidY = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), throtMax, -throtMax);
			graphPidZ = new GUIGraph (graphWidth, graphWidth, new Color (0.0f, 0.0f, 0.0f, 0.66f), new Color (1.0f, 1.0f, 1.0f, 1.0f), throtMax, -throtMax);
		}

		void OnGUI () {
			if (!Loader.HasLoaded) return;

			Vector3 curSpeed = this.transform.GetComponent<RotationSensor> ().getRotationSpeed ();
			graphRotX.draw (new Vector2 (10, Screen.height - 50 - graphWidth), curSpeed.x * 180.0f / 3.14f);
			graphRotY.draw (new Vector2 (20 + graphWidth, Screen.height - 50 - graphWidth), curSpeed.y * 180.0f / 3.14f);
			graphRotZ.draw (new Vector2 (30 + (2 * graphWidth), Screen.height - 50 - graphWidth), curSpeed.z * 180.0f / 3.14f);

			graphMotor1.draw (new Vector2 (10, Screen.height - 60 - (2 * graphWidth)), m1);
			graphMotor2.draw (new Vector2 (20 + graphWidth, Screen.height - 60 - (2 * graphWidth)), m2);
			graphMotor3.draw (new Vector2 (30 + (2 * graphWidth), Screen.height - 60 - (2 * graphWidth)), m3);
			graphMotor4.draw (new Vector2 (40 + (3 * graphWidth), Screen.height - 60 - (2 * graphWidth)), m4);

			graphPidX.draw (new Vector2 (10, Screen.height - 70 - (3 * graphWidth)), pidOutputX);
			graphPidY.draw (new Vector2 (20 + graphWidth, Screen.height - 70 - (3 * graphWidth)), pidOutputY);
			graphPidZ.draw (new Vector2 (30 + (2 * graphWidth), Screen.height - 70 - (3 * graphWidth)), pidOutputZ);

			// Fix style of labels so they align with the sliders
			GUIStyle style = new GUIStyle(GUI.skin.label);
			style.fixedWidth = 15;
			style.contentOffset = new Vector2(0, -5);

			// Visualize joystick input values
			GUILayout.BeginArea (new Rect (10, 10, 100, 200));
			GUILayout.BeginHorizontal ();
			GUILayout.Label ("P:", style);
			GUILayout.HorizontalSlider (-getAxis ("Pitch"), -1.0F, 1.0F);
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
			GUILayout.Label ("R:", style);
			GUILayout.HorizontalSlider (-getAxis ("Roll"), -1.0F, 1.0F);
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
			GUILayout.Label ("Y:", style);
			GUILayout.HorizontalSlider (-getAxis ("Yaw"), -1.0F, 1.0F);
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
			GUILayout.Label ("T:", style);
			GUILayout.HorizontalSlider (-Input.GetAxis ("Throttle"), -1.0F, 1.0F);
			GUILayout.EndHorizontal ();
			GUILayout.EndArea ();
		}

		private float getAxis(string s) {
			// Linear --> No expo
			// return Input.GetAxis (s);

			// Squared curve --> Slight expo
			float f = Input.GetAxis (s) * 100.0f;
			float v = (f * f) / (10.0f * 1000.0f);
			return (f < 0.0f) ? -v : v;
		}

		void FixedUpdate () {
			if (!Loader.HasLoaded) return;

			float baseSpeed = (-Input.GetAxis ("Throttle") + 1.0f) / 2.0f;
			baseSpeed -= 0.2f;
			if (baseSpeed < 0.0f) baseSpeed = 0.0f;
			baseSpeed *= throtMax;
			float targetPitch = getAxis ("Pitch") * maxAngularSpeed;
			float targetRoll = getAxis ("Roll") * maxAngularSpeed;
			float targetYaw = getAxis ("Yaw") * maxAngularSpeed;
			Vector3 targetSpeed = new Vector3 (targetPitch, targetYaw, targetRoll);

			/*
			if ((Input.GetAxis ("Throttle") == Input.GetAxis ("Roll"))
					&& (Input.GetAxis ("Roll") == Input.GetAxis ("Pitch"))
					&& (Input.GetAxis ("Pitch") == Input.GetAxis ("Yaw"))
					&& (Input.GetAxis ("Yaw") == 0.0f)) {
				// Assume no input is given at all, so don't apply throttle
				baseSpeed = 0.0f;
			}
			*/

			Vector3 currentSpeed = this.transform.GetComponent<RotationSensor> ().getRotationSpeed ();
			Vector3 errorSpeed = targetSpeed - currentSpeed;

			//calculate integrals
			integralX += errorSpeed.x * Time.fixedDeltaTime;
			integralY += errorSpeed.y * Time.fixedDeltaTime;
			integralZ += errorSpeed.z * Time.fixedDeltaTime;

			//calculate derivatives
			float derivX = (errorSpeed.x - lastError.x);
			float derivY = (errorSpeed.y - lastError.y);
			float derivZ = (errorSpeed.z - lastError.z);

			lastError = errorSpeed;

			pidOutputX = errorSpeed.x * pGain + integralX * iGain + derivX * dGain;
			pidOutputY = errorSpeed.y * pGain + integralY * iGain + derivY * dGain;
			pidOutputZ = errorSpeed.z * pGain + integralZ * iGain + derivZ * dGain;

			m1 = Mathf.Clamp ((baseSpeed + pidOutputX - pidOutputY), throtMin, throtMax);
			m2 = Mathf.Clamp ((baseSpeed + pidOutputZ + pidOutputY), throtMin, throtMax);
			m3 = Mathf.Clamp ((baseSpeed - pidOutputX - pidOutputY), throtMin, throtMax);
			m4 = Mathf.Clamp ((baseSpeed - pidOutputZ + pidOutputY), throtMin, throtMax);

			engine1.SetThrottle (m1);
			engine2.SetThrottle (m2);
			engine3.SetThrottle (m3);
			engine4.SetThrottle (m4);
		}
	}
}

using UnityEngine;
using System.Collections;

public class AttitudeControl : MonoBehaviour {



	public Engine engine1;
	public Engine engine2;
	public Engine engine3;
	public Engine engine4;
	public Transform sensorModule;
	public Debugger debugger;




	public Quaternion targetRot; // target rotation
	Quaternion errorRot; // error rotation
	Quaternion curRot; // current rotation
	Quaternion yawTarget; //Yaw target


	//integrals
	float integralX;
	float integralY;
	float integralZ;


	//throttle constraints

	public float throtMax;
	public float throtMin;

	Quaternion lastError;


	private int debugSample;


	//tunings

	public float pGain; // the proportional gain
	public float iGain; // the integral gain
	public float dGain; // the derivative gain



	public float targetAltitude;
	private float lastAltError;


	//integral

	private float integralA;

	//altitude tunings

	public float aPGain;
	public float aIGain;
	public float aDGain;


	Vector3 targetVelocity;

	private Vector3 integralV;

	//velocity tunings

	public float vPGain;
	public float vIGain;
	public float vDGain;

	private Vector3 lastVError;


	void Start(){



		targetRot = new Quaternion (0, 0, 0, 1);
		yawTarget = new Quaternion (0, 0, 0, 1);
		lastError = new Quaternion (0, 0, 0, 1);

		integralX = 0f;
		integralY = 0f;
		integralZ = 0f;

		pGain = 50f;
		iGain = 0.0f;
		dGain = 3000f;

		throtMax = 20f;
		throtMin = 15f;


		debugSample = 50;


		targetAltitude = 20f;

		integralA = 0f;

		aPGain = 1f;
		aIGain = 0f;
		aDGain = 300f;


		targetVelocity = new Vector3 (0, 0, 0);


		vPGain = 1f;
		vIGain = 0f;
		vDGain = 100f;

		integralV = new Vector3 (0, 0, 0);





	}
	
	void FixedUpdate(){

		AttitudeStablise ();
		AltitudeStablise ();
		VelocityStablise ();






				

	}

	private void VelocityStablise(){
		Vector3 currentVelocity = transform.InverseTransformDirection(GameObject.Find ("MainBody").GetComponent<Rigidbody> ().velocity) ;
		Vector3 velocityError = targetVelocity - currentVelocity;
		
		
		//calculate integrals
		
		integralV += velocityError * Time.deltaTime;
		
		
		
		//calculate derivatives
		
		Vector3 derivV = (velocityError - lastVError);
		lastVError = velocityError;
		
		//calculate velocity correction
		
		Vector3 VCorrection = velocityError * vPGain + integralV * vIGain + derivV * vDGain;
		
		
		
		//engine1.SetThrottle (Mathf.Clamp ((engine1.getThrottle () + VCorrection.z), throtMin, throtMax));
		//engine3.SetThrottle (Mathf.Clamp ((engine3.getThrottle () - VCorrection.z), throtMin, throtMax));
		
		
		
		if (debugSample == 50) {
			Debugger.Log (string.Format ("X: {0} Y: {1} Z: {2} ", VCorrection.x, VCorrection.y, VCorrection.z));
			debugSample = 0;
		} else {
			debugSample++;
		}
		}


	private void AltitudeStablise(){
		//stablise altitude
		
		float currentAltitude = sensorModule.GetComponent<Altimeter> ().altitude;
		
		
		
		
		float altitudeError = targetAltitude - currentAltitude;
		
		//calculate integrals
		
		integralA += altitudeError * Time.deltaTime;
		
		
		
		//calculate derivatives
		
		float derivA = (altitudeError - lastAltError);
		lastAltError = altitudeError;
		
		//calculate altitude correction
		
		float altCorrection = altitudeError * aPGain + integralA * aIGain + derivA * aDGain;
		//Debugger.Log (string.Format ("altcorrection: {0}" , altCorrection));
		
		throtMin = Mathf.Clamp( throtMin + altCorrection,2,98);
		throtMax = throtMin + 5;
		
		//throtMin = Mathf.Clamp (throtMin + altCorrection, 1 , throtMax - 1);
		
		//Debugger.Log (string.Format ("throtmin: {0}", throtMin));	
		
		//throtMax = throtMin +1;
		
		//engine1.SetThrottle( engine1.getThrottle() + altCorrection);
		//engine2.SetThrottle( engine2.getThrottle() + altCorrection);
		//engine3.SetThrottle( engine3.getThrottle() + altCorrection);
		//engine4.SetThrottle( engine4.getThrottle() + altCorrection);

		}

	private void AttitudeStablise(){

		//get current rotation
		curRot = sensorModule.GetComponent<RotationSensor> ().getRotation ();
		
		//get error signal
		errorRot = Quaternion.Inverse (curRot) * targetRot;
		
		
		//calculate integrals
		
		integralX += errorRot.x * Time.deltaTime;
		integralY += errorRot.y * Time.deltaTime;
		integralZ += errorRot.z * Time.deltaTime;
		
		
		//calculate derivatives
		
		float derivX = (errorRot.x - lastError.x);
		float derivY = (errorRot.y - lastError.y);
		float derivZ = (errorRot.z - lastError.z);
		
		
		
		lastError = errorRot;
		
		//caluculate corrections
		float pitchCorrectionX = errorRot.x * pGain + integralX * iGain + derivX * dGain;
		float pitchCorrectionY = errorRot.y * pGain + integralY * iGain + derivY * dGain;
		float pitchCorrectionZ = errorRot.z * pGain + integralZ * iGain + derivZ * dGain;
		

		
		
		//apply corrections
		
		
		
		//pitch
		engine1.SetThrottle (Mathf.Clamp ((engine1.getThrottle () + pitchCorrectionZ), throtMin, throtMax));
		engine3.SetThrottle (Mathf.Clamp ((engine3.getThrottle () - pitchCorrectionZ), throtMin, throtMax));
		
		//roll
		engine2.SetThrottle (Mathf.Clamp ((engine2.getThrottle () + pitchCorrectionX), throtMin, throtMax));
		engine4.SetThrottle (Mathf.Clamp ((engine4.getThrottle () - pitchCorrectionX), throtMin, throtMax));
		
		//yaw
		
		engine1.SetThrottle (Mathf.Clamp ((engine1.getThrottle () + pitchCorrectionY), throtMin, throtMax));
		engine3.SetThrottle (Mathf.Clamp ((engine3.getThrottle () + pitchCorrectionY), throtMin, throtMax));
		engine2.SetThrottle (Mathf.Clamp ((engine2.getThrottle () - pitchCorrectionY), throtMin, throtMax));
		engine4.SetThrottle (Mathf.Clamp ((engine4.getThrottle () - pitchCorrectionY), throtMin, throtMax));
	}

}




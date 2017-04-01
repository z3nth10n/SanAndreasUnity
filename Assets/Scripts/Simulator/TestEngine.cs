using UnityEngine;
using System.Collections;

public class TestEngine : MonoBehaviour {


	Vector3 targetPos = Vector3.zero; // the desired position
	float maxForce = 100f; // the max force available
	float pGain = 20f; // the proportional gain
	float iGain = 0.5f; // the integral gain
	float dGain = 0.5f; // differential gain
	private Vector3 integrator = Vector3.zero; // error accumulator
	private Vector3 lastError = Vector3.zero;
	Vector3 curPos = Vector3.zero; // actual Pos
	Vector3 force = Vector3.zero; // current force

	void Start(){
		targetPos = transform.position;
	}

	void FixedUpdate(){
		curPos = transform.position;
		Vector3 error = targetPos - curPos; // generate the error signal
		integrator += error * Time.deltaTime; // integrate error
		Vector3 diff = (error - lastError)/ Time.deltaTime; // differentiate error
		lastError = error;
		// calculate the force summing the 3 errors with respective gains:
		force = error * pGain + integrator * iGain + diff * dGain;
		// clamp the force to the max value available
		force = Vector3.ClampMagnitude(force, maxForce);
		// apply the force to accelerate the rigidbody:
		rigidbody.AddForce(force);
	}
}

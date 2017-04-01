using UnityEngine;
using System.Collections;
using System.Collections.Generic;





public class Altimeter : MonoBehaviour {

    
    public float altitude;
	private RaycastHit hit;



	// Use this for initialization
	void Start () {



		/*altitude = 10F;

		if (Physics.Raycast(transform.position, -Vector3.up, out hit)){
			
			altitude = hit.distance;
			Debug.Log(altitude);
		}
		*/

	}
	
	// Update is called once per frame
	void Update () {


		if (Physics.Raycast(transform.position, -Vector3.up, out hit)){

			altitude = hit.distance;
			//Debug.Log(altitude);
			          }
		Debug.DrawLine(transform.position, -Vector3.up, Color.red);


	
	}

     

    
}

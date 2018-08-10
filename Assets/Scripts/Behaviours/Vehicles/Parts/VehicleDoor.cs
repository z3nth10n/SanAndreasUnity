﻿using SanAndreasUnity.Behaviours.Vehicles;
using SanAndreasUnity.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleDoor : VehicleBehaviour
{
    private const float sqr_damageDist = 20;

    private bool _isLeft;

    private bool _isLocked;
    public bool isLocked
    {
        get
        {
            return _isLocked;
        }

        set
        {
            _isLocked = value;

            if (joint != null)
            {
                JointLimits limits = joint.limits;
                limits.min = _isLocked ? 0 : (_isLeft ? 0 : -90);
                limits.max = _isLocked ? 0 : (_isLeft ? 90 : 0);
                joint.limits = limits;
            }

            Debug.LogFormat("{0} {1} from {2}", _isLocked ? "Closing" : "Opening", transform.name, vehicle.name);
        }
    }

    public float force;

    private float lastForce;
    private bool allowedToDebug;
    private Rigidbody body, vehicleBody;
    private Vehicle vehicle;

    private float lockHealth = 100;
    private HingeJoint joint;
    //private MeshCollider okCollider, damCollider;
    private NonConvexMeshCollider okCollider, damCollider;

    public static VehicleDoor InitializateDoor(Transform door, Vehicle vehicle)
    {
        if (door == null) return null;

        VehicleDoor doorObj = door.gameObject.AddComponent<VehicleDoor>();

        doorObj.vehicle = vehicle;
        doorObj.vehicleBody = vehicle.GetComponent<Rigidbody>();

        doorObj._isLeft = doorObj.name.Contains("_lf_") || doorObj.name.Contains("_lr_");

        doorObj.allowedToDebug = doorObj.name.Contains("_lf_");

        return doorObj;
    }

	// Use this for initialization
	void Start ()
    {
        TextGizmo.Init();

        body = GetComponent<Rigidbody>();
        joint = GetComponent<HingeJoint>();

        CheckDoorState();

        joint.breakForce = 5000 / vehicle.HandlingData.CollisionDamageMult;

        //string prefix = transform.name.Substring(0, 7);

        //Debug.Log(prefix);
        //Debug.Log(transform.Find(string.Format("{0}_ok", prefix)).gameObject == null);

        /*okCollider = transform.Find(string.Format("{0}_ok", prefix)).gameObject.AddComponent<NonConvexMeshCollider>();
        damCollider = transform.Find(string.Format("{0}_dam", prefix)).gameObject.AddComponent<NonConvexMeshCollider>();

        Collider[] allCols = vehicle.gameObject.GetComponentsInChildren<Collider>();

        foreach (Collider col in allCols)
            col.gameObject.layer = LayerMask.NameToLayer("CarCollider");

        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("CarCollider"), LayerMask.NameToLayer("DoorCollider"));

        Collider[] doorCols = okCollider.Calculate(LayerMask.NameToLayer("DoorCollider"));*/

        /*foreach (Collider col1 in allCols)
            foreach (Collider col2 in doorCols)
                Physics.IgnoreCollision(col1, col2);*/

        // We have to build the collidrs, but they don't work correctly
    }
	
	// Update is called once per frame
	void Update ()
    {
        //drag = body.angularVelocity.magnitude;

        force = (vehicleBody.mass * .015f) * Mathf.Pow(vehicleBody.angularVelocity.magnitude, 2) * Vector3.Distance(vehicle.transform.TransformPoint(vehicleBody.centerOfMass), transform.position);



        if (force > lastForce && allowedToDebug)
        {
            //Debug.Log("NEW MAX: " + drag);
            lastForce = force;
        }
    }

    private bool TryOpenDoor()
    {
        if (force > 100 && GetChance(false))
            isLocked = false;

        return isLocked;
    }

    private void TryCloseDoor(bool debuging = false)
    {
        if (debuging)
        {
            // If rotation from the hinge is 0 (== can be closed) block the door
            float v = 0;
            bool angle = transform.localEulerAngles.y < 1 || transform.localEulerAngles.y > 359, chance = GetChance(true, out v);
            Debug.LogFormat("Angle: {0}; Chance: {1} ({2} > {3})", angle, chance, v, lockHealth / 100f);
            Debug.Break();
            if (angle && chance)
                isLocked = true;
        }
        else
        {
            if ((transform.localEulerAngles.y < 1 || transform.localEulerAngles.y > 359) && GetChance(true))
                isLocked = true;
        }
    }

    private bool GetChance(bool isClosing)
    {
        float val = 0;
        return GetChance(isClosing, out val);
    }

    private bool GetChance(bool isClosing, out float val)
    {
        val = Random.value;
        return isClosing ? val < lockHealth / 100f : val < (1f - lockHealth / 100f);
    }

    private void CheckDoorState()
    { // Nested bools before
        if (isLocked)
            TryOpenDoor(); // !IsLocked == Opened

        if (!isLocked)
            TryCloseDoor();
    }

    private void OnDrawGizmos()
    {
#if UNITY_EDITOR
        F.DrawString(transform.position, transform.localEulerAngles.y.ToString("F2"));
#endif
    }

    public override void OnVehicleCollisionEnter(Collision collision)
    {
        TryOpenDoor();
        if ((collision.contacts[0].point - transform.position).magnitude < sqr_damageDist)
            lockHealth -= force / 1000f;
    }

    public override void OnVehicleCollisionExit(Collision collision)
    {

    }

    public override void OnVehicleCollisionStay(Collision collision)
    {

    }

    public override void OnVehicleTriggerEnter(Collider other)
    {
        
    }

    public override void OnVehicleTriggerExit(Collider other)
    {
        
    }

    public override void OnVehicleTriggerStay(Collider other)
    {
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VehicleBehaviour : MonoBehaviour
{
    public abstract void OnVehicleCollisionEnter(Collision collision);

    public abstract void OnVehicleCollisionExit(Collision collision);

    public abstract void OnVehicleCollisionStay(Collision collision);
}

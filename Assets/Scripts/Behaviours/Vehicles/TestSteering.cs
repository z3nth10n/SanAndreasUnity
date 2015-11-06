using UnityEngine;
using SanAndreasUnity.Behaviours.Vehicles;
using Valve.VR;

public class TestSteering : MonoBehaviour
{
    public Vehicle Vehicle;
    public Transform WheelTransform;

    public SteamVR_TrackedObject Controller;

    private SteamVR_Controller.Device _controllerDevice;

    private void UpdateWithValidDevice(SteamVR_Controller.Device device)
    {
        if (Vehicle == null) return;

        Vehicle.Accelerator = device.GetHairTrigger() ? 1f : device.GetPress(EVRButtonId.k_EButton_Grip) ? -1f : 0f;
        Vehicle.Braking = 0f;
        Vehicle.Steering = -Vector3.Dot(transform.forward, transform.parent.right);
    }

    private void Update()
    {
        if (_controllerDevice != null)
        {
            UpdateWithValidDevice(_controllerDevice);
            return;
        }

        if (!Controller.isValid) return;
        _controllerDevice = SteamVR_Controller.Input((int) Controller.index);
    }
}

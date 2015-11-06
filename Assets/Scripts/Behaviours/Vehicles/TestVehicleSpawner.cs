using UnityEngine;
using System.Linq;
using SanAndreasUnity.Behaviours.Vehicles;

public class TestVehicleSpawner : MonoBehaviour
{
    public int VehicleId = -1;
    public Transform CameraRig;
    public TestSteering Steering;

    private void OnEnable()
    {
        var vehicle = Vehicle.Create(transform, VehicleId);

        var seats = vehicle.transform.GetAllChildren().Where(x => x.name == "ped_frontseat").ToArray();
        var frontSeat = seats.FirstOrDefault(x => x.transform.localPosition.x < 0f) ?? seats.First();
        
        CameraRig.transform.SetParent(frontSeat, true);
        CameraRig.transform.localPosition = new Vector3(0f, -0.5f, 0f);
        CameraRig.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
        CameraRig.transform.localScale = Vector3.one;
        
        Steering.Vehicle = vehicle;

        Destroy(gameObject);
    }
}

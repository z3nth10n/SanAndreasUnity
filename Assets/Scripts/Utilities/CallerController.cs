using SanAndreasUnity.Behaviours;
using SanAndreasUnity.Utilities;
using System.Collections;
using UnityEngine;

// This is used only for attached MonoBehaviour calls
// And for get prefabs
public class CallerController : MonoBehaviour
{
    public static CallerController Instance;

    public GameObject progressBar;

    private void Awake()
    {
        Instance = this;

        ZHelpers.Awake();
    }

    // Use this for initialization
    private void Start()
    {
        ZHelpers.Start();
    }

    private IEnumerator CreateRagdoll()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();

        GameObject pedObj = new GameObject("PedObj");
        pedObj.transform.position = Player.InstancePos + Vector3.up * 3;

        Pedestrian ped = pedObj.AddComponent<Pedestrian>();

        CharacterModelChanger.ChangePedestrianModel(ped, Player.Instance.PlayerModel.PedestrianId);

        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();

        RagdollBuilder.ToRagdoll(ped.transform);

        pedObj.GetComponent<Animation>().enabled = false;
    }

    public void OnLoaderFinished()
    {
        // Some tests

        StartCoroutine(CreateRagdoll());
    }

    // Update is called once per frame
    private void Update()
    {
        ZHelpers.Update();
    }

    private void OnGUI()
    {
        ZHelpers.OnGUI();
    }

    private void OnDisable()
    {
        ZHelpers.OnDisable();
    }

    private void OnApplicationQuit()
    {
        ZHelpers.OnApplicationQuit();
    }
}
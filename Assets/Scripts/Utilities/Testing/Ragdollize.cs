using SanAndreasUnity.Behaviours;
using SanAndreasUnity.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Ragdollize : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {

    }

    private IEnumerator CreateRagdoll()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();

        GameObject go = AssetLoader.objects[0];

        /*GameObject pedObj = new GameObject("PedObj");
        pedObj.transform.position = Player.InstancePos + Vector3.up * 3;

        Pedestrian ped = pedObj.AddComponent<Pedestrian>();

        CharacterModelChanger.ChangePedestrianModel(ped, Player.Instance.PlayerModel.PedestrianId);

        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();*/

        RagdollBuilder builder = RagdollBuilder.ToRagdoll(go.transform); // ped.transform

        //pedObj.GetComponent<Animation>().enabled = false;

/*#if UNITY_EDITOR
        GameObject Root = builder.pelvis.gameObject;
        SkinnedMeshRenderer ren = Root.GetComponent<SkinnedMeshRenderer>();
        AssetSaver.SaveMesh(ren.sharedMesh);
        File.WriteAllBytes(Path.Combine(AssetSaver.SavePath, "player-tex.png"), ((Texture2D)ren.material.mainTexture).EncodeToPNG());
#endif*/
    }

    public void OnLoaderFinished()
    {
        // Some tests

        StartCoroutine(CreateRagdoll());
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
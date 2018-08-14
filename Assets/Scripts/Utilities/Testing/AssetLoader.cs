using SanAndreasUnity.Utilities;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AssetLoader : MonoBehaviour
{
    public List<ResourceAsset> resourceAssets = new List<ResourceAsset>();

    public static List<GameObject> objects = new List<GameObject>();

    // Use this for initialization
    private void Start()
    {
        for (int i = 0; i < resourceAssets.Count; ++i)
            objects.Add(resourceAssets[i].Instantiate());
    }

    // Update is called once per frame
    private void Update()
    {
    }
}

[Serializable]
public class ResourceAsset
{
    public TextAsset textAsset;
    public Vector3 position = Vector3.zero;
    public Material material;

    public GameObject Instantiate(Transform parent = null)
    {
        Mesh mesh = MeshSerializer.DeserializeMesh(textAsset.bytes);

        GameObject gameObject = new GameObject(textAsset.name);

        MeshRenderer ren = gameObject.AddComponent<MeshRenderer>();
        ren.material = material;

        MeshFilter fil = gameObject.AddComponent<MeshFilter>();
        fil.mesh = mesh;

        if (parent != null) gameObject.transform.parent = parent;

        return gameObject;
    }
}
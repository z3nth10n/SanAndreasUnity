using UnityEngine;
using System.IO;
using SanAndreasUnity.Utilities;

public class AssetSaver
{
    public static string SavePath
    {
        get
        {
            string f = Path.Combine(Application.streamingAssetsPath, "Saved-Assets");
            if (!Directory.Exists(f)) Directory.CreateDirectory(f);
            return f;
        }
    }

    public static void SaveMesh(Mesh mesh)
    {
        string name = string.IsNullOrEmpty(mesh.name) ? Random.Range(0, short.MaxValue).ToString() : mesh.name;
        File.WriteAllBytes(Path.Combine(SavePath, name + ".asset"), MeshSerializer.SerializeMesh(mesh));
    }
}
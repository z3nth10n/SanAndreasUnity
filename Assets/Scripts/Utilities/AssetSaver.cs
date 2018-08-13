#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System.IO;

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
        AssetDatabase.CreateAsset(mesh, Path.Combine(SavePath, name + ".asset"));
    }
}

#endif
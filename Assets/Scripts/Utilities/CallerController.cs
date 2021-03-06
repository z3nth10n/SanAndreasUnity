﻿using SanAndreasUnity.Behaviours;
using SanAndreasUnity.Utilities;
using System.Collections;
using System.IO;
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
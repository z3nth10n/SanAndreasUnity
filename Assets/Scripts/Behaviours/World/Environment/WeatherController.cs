﻿using System.Collections.Generic;
using UnityEngine;

public class WeatherController : ColorController
{
    public static WeatherController Instance;

    // Use this for initialization
    private void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
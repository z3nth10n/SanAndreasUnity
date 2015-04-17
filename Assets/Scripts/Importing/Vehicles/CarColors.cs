﻿using System.Collections.Generic;
using System.Linq;
using SanAndreasUnity.Importing.Items;
using SanAndreasUnity.Importing.Items.Definitions;
using UnityEngine;

namespace SanAndreasUnity.Importing.Vehicles
{
    public class CarColors
    {
        private static Color32[] _sColors;
        private static Dictionary<string, CarColors> _sCarColors;

        public static void Load(string path)
        {
            var file = new ItemFile<Definition>(path);

            Debug.LogFormat("Entries: {0}", file.GetItems<CarColorDef>().Count());

            _sColors = file.GetItems<ColorDef>().Select(x => new Color32(x.R, x.G, x.B, 255)).ToArray();
            _sCarColors = file.GetItems<CarColorDef>().ToDictionary(x => x.Name, x => new CarColors(x));
        }

        public static CarColors GetCarDefaults(string carName)
        {
            return _sCarColors.ContainsKey(carName) ? _sCarColors[carName] : null;
        }

        public static Color32[] FromIndices(params int[] indices)
        {
            return indices.Select(x => _sColors[x]).ToArray();
        }

        private readonly CarColorDef _def;
        private readonly Color32[][] _vals;

        public int Count { get { return _def.Colors.Length; } }

        private CarColors(CarColorDef def)
        {
            _def = def;
            _vals = _def.Colors.Select(x => {
                var arr = new Color32[def.Is4Color ? 4 : 2];
                arr[0] = _sColors[x.A];
                // To fix "moonbeam" having an invalid second color
                arr[1] = _sColors[x.B < _sColors.Length ? x.B : x.A];
                if (!def.Is4Color) return arr;
                arr[2] = _sColors[x.C];
                arr[3] = _sColors[x.D];
                return arr;
            }).ToArray();
        }

        public Color32[] this[int index]
        {
            get { return _vals[index]; }
        }
    }
}

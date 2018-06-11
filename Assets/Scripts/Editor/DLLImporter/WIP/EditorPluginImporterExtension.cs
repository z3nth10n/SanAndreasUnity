﻿// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

/*using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;
using UnityEditor.Modules;
using UnityEditor.Graphs;

namespace UnityEditor
{
    public class EditorPluginImporterExtension : DefaultPluginImporterExtension
    {
        internal enum EditorPluginCPUArchitecture
        {
            AnyCPU,
            x86,
            x86_64
        };

        internal enum EditorPluginOSArchitecture
        {
            AnyOS,
            OSX,
            Windows,
            Linux
        };

        internal class EditorProperty : Property
        {
            public EditorProperty(GUIContent name, string key, object defaultValue)
                : base(name, key, defaultValue, FEditor.GetEditorTargetName())
            {
            }

            internal override void Reset(DLLFileWrapperInspector inspector)
            {
                string valueString = inspector.importer.GetEditorData(key);
                ParseStringValue(inspector, valueString);
            }

            internal override void Apply(DLLFileWrapperInspector inspector)
            {
                inspector.importer.SetEditorData(key, value.ToString());
            }
        }

        public EditorPluginImporterExtension() : base(GetProperties())
        {
        }

        private static Property[] GetProperties()
        {
            return new[]
            {
                new EditorProperty(FEditorGUI.TrTextContent("CPU", "Is plugin compatible with 32bit or 64bit Editor?"), "CPU", EditorPluginCPUArchitecture.AnyCPU),
                new EditorProperty(FEditorGUI.TrTextContent("OS", "Is plugin compatible with Windows, OS X or Linux Editor?"), "OS", EditorPluginOSArchitecture.AnyOS),
            };
        }
    }
}*/
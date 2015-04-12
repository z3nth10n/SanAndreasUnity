﻿using System.IO;
using System.Linq;
using System.Collections.Generic;
using SanAndreasUnity.Utilities;
using SanAndreasUnity.Importing.Archive;
using SanAndreasUnity.Importing.Conversion;
using SanAndreasUnity.Importing.Items;
using SanAndreasUnity.Importing.Items.Definitions;
using SanAndreasUnity.Importing.Animation;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace SanAndreasUnity.Behaviours
{
    [ExecuteInEditMode]
    public class Pedestrian : MonoBehaviour
    {
        private int _loadedPedestrianId;
        private AnimType _loadedAnimType = AnimType.None;

        private FrameContainer _frames;

        public PedestrianDef Definition { get; private set; }

        public int PedestrianId = 7;

        public AnimType Anim = AnimType.Idle;

        public bool Walking
        {
            set
            {
                Anim = value ? AnimType.Walk : AnimType.Idle;
            }
        }

        public bool Running
        {
            set
            {
                Anim = value ? AnimType.Run : AnimType.Walk;
            }
        }

        public Vector3 Position
        {
            get { return transform.localPosition; }
            set { transform.localPosition = value; }
        }

        private void Update()
        {
            if (!Loader.HasLoaded) return;
#if UNITY_EDITOR
            if (!EditorApplication.isPlaying && !EditorApplication.isPaused) return;
#endif

            if (_loadedPedestrianId != PedestrianId) {
                _loadedPedestrianId = PedestrianId;
                _loadedAnimType = AnimType.None;

                Load(PedestrianId);
            }

            if (_loadedAnimType != Anim) {
                _loadedAnimType = Anim;

                LoadAnim(Anim);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (Anim == AnimType.Walk) Anim = AnimType.Run;
                else if (Anim == AnimType.Run) Anim = AnimType.Walk; 
            }
        }

        private void OnValidate()
        {
            if (_frames != null) Update();
        }

        private void Load(int id)
        {
            Definition = Item.GetDefinition<PedestrianDef>(id);
            if (Definition == null) return;

            LoadModel(Definition.ModelName, Definition.TextureDictionaryName);
        }

        private void LoadModel(string modelName, params string[] txds)
        {
            if (_frames != null) {
                Destroy(_frames.Root.gameObject);
                Destroy(_frames);
            }

            var geoms = Geometry.Load(modelName, txds);
            _frames = geoms.AttachFrames(transform, MaterialFlags.Default);
        }

        private void LoadAnim(AnimType type)
        {
            var anim = gameObject.GetComponent<UnityEngine.Animation>();
            if (anim == null) {
                anim = gameObject.AddComponent<UnityEngine.Animation>();
            }

            if (type == AnimType.None) {
                anim.Stop();
                return;
            }

            var group = AnimationGroup.Get(Definition.AnimGroupName);
            var animName = group[Anim];
            var clip = Importing.Conversion.Animation.Load(group.FileName, animName, _frames);

            anim.AddClip(clip, animName);
            anim.CrossFade(animName);
        }
    }
}

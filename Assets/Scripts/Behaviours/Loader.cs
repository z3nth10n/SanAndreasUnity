﻿using System.IO;
using SanAndreasUnity.Importing.Animation;
using SanAndreasUnity.Importing.Archive;
using SanAndreasUnity.Importing.Collision;
using SanAndreasUnity.Importing.Conversion;
using SanAndreasUnity.Importing.Items;
using SanAndreasUnity.Importing.Vehicles;
using SanAndreasUnity.Utilities;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SanAndreasUnity.Behaviours
{
	
    public class Loader : MonoBehaviour
    {
        
		public static bool HasLoaded { get; private set; }

		public static string LoadingStatus { get; private set; }

		private static int m_currentStepIndex = 0;

		private static float m_totalEstimatedLoadingTime = 0;

        private static string[] archivePaths;
        private static IArchive[] archives;

		private	static System.Diagnostics.Stopwatch m_stopwatch = new System.Diagnostics.Stopwatch();

		public class LoadingStep
		{
			public IEnumerator Coroutine { get; private set; }
			public System.Action LoadFunction { get; private set; }
			public string Description { get; set; }
			public bool StopLoadingOnException { get; private set; }
			public float TimeElapsed { get; internal set; }
			public float EstimatedTime { get; private set; }

			public LoadingStep (System.Action loadFunction, string description, float estimatedTime = 0f, bool stopLoadingOnException = true)
			{
				this.LoadFunction = loadFunction;
				this.Description = description;
				this.EstimatedTime = estimatedTime;
				this.StopLoadingOnException = stopLoadingOnException;
			}

			public LoadingStep (IEnumerator coroutine, string description, float estimatedTime = 0f, bool stopLoadingOnException = true)
			{
				this.Coroutine = coroutine;
				this.Description = description;
				this.EstimatedTime = estimatedTime;
				this.StopLoadingOnException = stopLoadingOnException;
			}
			
		}

		private static List<LoadingStep> m_loadingSteps = new List<LoadingStep> ();

		public static Texture2D CurrentSplashTex { get; set; }
		public static Texture2D SplashTex1 { get; set; }
		public static Texture2D SplashTex2 { get; set; }



		void Start ()
		{

			AddLoadingSteps ();

			StartCoroutine (LoadCoroutine ());

		}

		private static void AddLoadingSteps ()
		{
			
			LoadingStep[] steps = new LoadingStep[] {
				new LoadingStep ( StepGetPaths, "Loading archive paths" ),
				new LoadingStep ( StepLoadArchives, "Loading archives", 1.7f ),
				new LoadingStep ( StepLoadSplashScreen, "Loading splash screen" ),
				new LoadingStep ( StepSetSplash1, "Set splash 1" ),
				new LoadingStep ( StepLoadCollision, "Loading collision files", 0.9f ),
				new LoadingStep ( StepLoadItemInfo, "Loading item info", 2.4f ),
				new LoadingStep ( StepLoadHandling, "Loading handling", 0.01f ),
				new LoadingStep ( StepLoadAnimGroups, "Loading animation groups", 0.02f ),
				new LoadingStep ( StepLoadCarColors, "Loading car colors", 0.04f ),
				new LoadingStep ( StepLoadWeaponsData, "Loading weapons data", 0.05f ),
				new LoadingStep ( StepSetSplash2, "Set splash 2" ),
				new LoadingStep ( StepLoadMap, "Loading map", 2f ),
				new LoadingStep ( StepLoadSpecialTextures, "Loading special textures", 0.05f ),
			};


			for (int i = 0; i < steps.Length; i++) {
				AddLoadingStep (steps [i]);
			}


			if (Behaviours.World.Cell.Instance != null) {
				// add step for cell
				AddLoadingStep( new LoadingStep( () => Behaviours.World.Cell.Instance.Setup (), "World setup", 7.5f ) );
			}

		}

		private static void AddLoadingStep (LoadingStep step)
		{
			m_loadingSteps.AddIfNotPresent (step);
		}


		private static IEnumerator LoadCoroutine ()
		{

			// wait a few frames - to "unblock" the program, and to let other scripts initialize before
			// registering their loading steps
			yield return null;
			yield return null;

			// calculate total loading time
			m_totalEstimatedLoadingTime = m_loadingSteps.Sum( step => step.EstimatedTime );

			var stopwatchForSteps = new System.Diagnostics.Stopwatch ();

			foreach (var step in m_loadingSteps) {

				// update description
				LoadingStatus = step.Description;
				yield return null;

				stopwatchForSteps.Stop ();
				stopwatchForSteps.Start ();

				var en = step.Coroutine;

				if (en != null) {
					// this step uses coroutine

					bool hasNext = true;

					while (hasNext) {

						hasNext = false;
						try {
							hasNext = en.MoveNext ();
						} catch (System.Exception ex) {
							Debug.LogException (ex);
							if (step.StopLoadingOnException) {
								yield break;
							}
						}

						// update description
						LoadingStatus = step.Description;
						yield return null;

					}
				} else {
					// this step uses a function

					try {
						step.LoadFunction ();
					} catch(System.Exception ex) {
						Debug.LogException (ex);
						if (step.StopLoadingOnException) {
							yield break;
						}
					}
				}

				// step finished it's work

				step.TimeElapsed = stopwatchForSteps.ElapsedMilliseconds;

				m_currentStepIndex++;
			}

			// all steps finished loading

			HasLoaded = true;

			Debug.Log("GTA loading finished in " + m_stopwatch.Elapsed.TotalSeconds + " seconds");

		}


		private static void StepGetPaths ()
		{
			//Debug.Log("Checking if there is available a GTA SA path.");

			//DevProfiles.CheckDevProfiles(null);

			/*() =>
                    {
                        m_fileBrowser.Toggle();
                        return m_fileBrowser.GetPath();
                    }*/

			m_stopwatch.Start ();

			Debug.Log("Started loading GTA");

			archivePaths = Config.GetPaths("archive_paths");

		}

		private static void StepLoadArchives ()
		{
			
			using (Profiler.Start("Archive load time"))
			{
				List<IArchive> listArchives = new List<IArchive>();
				foreach (var path in archivePaths)
				{
					if (File.Exists(path))
					{
						listArchives.Add(ArchiveManager.LoadImageArchive(path));
					}
					else if (Directory.Exists(path))
					{
						listArchives.Add(ArchiveManager.LoadLooseArchive(path));
					}
					else
					{
						Debug.LogError("Archive not found: " + path);
					}
				}
				archives = listArchives.FindAll(a => a != null).ToArray();
			}

		}

		private static void StepLoadSplashScreen ()
		{
			var txd = TextureDictionary.Load ("LOADSCS");

			int index1 = Random.Range (1, 14);
			int index2 = Random.Range (1, 14);

			SplashTex1 = txd.GetDiffuse ("loadsc" + index1).Texture;
			SplashTex2 = txd.GetDiffuse ("loadsc" + index2).Texture;

		}

		private static void StepSetSplash1 ()
		{
			CurrentSplashTex = SplashTex1;
		}

		private static void StepSetSplash2 ()
		{
			CurrentSplashTex = SplashTex2;
		}

		private static void StepLoadCollision ()
		{
			using (Profiler.Start("Collision load time"))
			{
				int numCollisionFiles = 0;
				foreach (var archive in archives)
				{
					foreach (var colFile in archive.GetFileNamesWithExtension(".col"))
					{
						CollisionFile.Load(colFile);
						numCollisionFiles++;
					}
				}
				Debug.Log("Number of collision files " + numCollisionFiles);
			}
		}

		private static void StepLoadItemInfo ()
		{
			using (Profiler.Start("Item info load time"))
			{
				foreach (var path in Config.GetPaths("item_paths"))
				{
					var ext = Path.GetExtension(path).ToLower();
					switch (ext)
					{
					case ".dat":
						Item.ReadLoadList(path);
						break;

					case ".ide":
						Item.ReadIde(path);
						break;

					case ".ipl":
						Item.ReadIpl(path);
						break;
					}
				}
			}
		}

		private static void StepLoadHandling ()
		{
			using (Profiler.Start("Handling info load time"))
			{
				Handling.Load(Config.GetPath("handling_path"));
			}
		}

		private static void StepLoadAnimGroups ()
		{
			using (Profiler.Start("Animation group info load time"))
			{
				foreach (var path in Config.GetPaths("anim_groups_paths"))
				{
					AnimationGroup.Load(path);
				}
			}
		}

		private static void StepLoadCarColors ()
		{
			using (Profiler.Start("Car color info load time"))
			{
				CarColors.Load(Config.GetPath("car_colors_path"));
			}
		}

		private static void StepLoadWeaponsData ()
		{
			using (Profiler.Start("Weapons data load time"))
			{
				Importing.Weapons.WeaponData.Load(Config.GetPath("weapons_path"));
			}
		}

		private static void StepLoadMap ()
		{
			using (Profiler.Start ("Minimap load time")) {
				//MiniMap.loadTextures();
				MiniMap.AssingMinimap ();
			}
		}

		private static void StepLoadSpecialTextures ()
		{
			using (Profiler.Start("Special texture load time"))
			{

				// Load mouse cursor texture
				Texture2D mouse = TextureDictionary.Load("fronten_pc").GetDiffuse("mouse").Texture;
				Texture2D mouseFix = new Texture2D(mouse.width, mouse.height);

				for (int x = 0; x < mouse.width; x++)
					for (int y = 0; y < mouse.height; y++)
						mouseFix.SetPixel(x, mouse.height - y - 1, mouse.GetPixel(x, y));

				mouseFix.Apply();
				Cursor.SetCursor(mouseFix, Vector2.zero, CursorMode.Auto);

				// load crosshair texture
				Weapon.CrosshairTexture = TextureDictionary.Load("hud").GetDiffuse("siteM16").Texture;

				// fist texture
				Weapon.FistTexture = TextureDictionary.Load("hud").GetDiffuse("fist").Texture;

			}
		}



		public static float GetProgressPerc ()
		{
			if (m_currentStepIndex <= 0)
				return 0f;

			if (m_currentStepIndex >= m_loadingSteps.Count)
				return 1f;

			float estimatedTimePassed = 0f;
			for (int i = 0; i < m_currentStepIndex; i++) {
				estimatedTimePassed += m_loadingSteps [i].EstimatedTime;
			}

			return Mathf.Clamp01 (estimatedTimePassed / m_totalEstimatedLoadingTime);
		}


        private void Update()
        {
			
        }

        private void OnGUI()
        {
            if (HasLoaded)
                return;

			// background

			if (CurrentSplashTex != null) {
				GUIUtils.DrawTextureWithYFlipped (new Rect (0, 0, Screen.width, Screen.height), CurrentSplashTex);
			} else {
				GUIUtils.DrawRect (new Rect (0, 0, Screen.width, Screen.height), Color.black);
			}

            // display loading progress

			GUILayout.BeginArea(new Rect(10, 5, 400, Screen.height));

			// current status
			GUILayout.Label("<size=25>" + LoadingStatus + "</size>");

			// progress bar
			GUILayout.Space (10);
			DisplayProgressBar ();

			// display all steps
//			GUILayout.Space (10);
//			DisplayAllSteps ();

            GUILayout.EndArea();
        }

		private static void DisplayAllSteps ()
		{

			int i=0;
			foreach (var step in m_loadingSteps) {
				GUILayout.Label( step.Description + (m_currentStepIndex > i ? (" - " + step.TimeElapsed + " ms") : "") );
				i++;
			}

		}

		private static void DisplayProgressBar ()
		{
			float width = 200;
			float height = 12;

//			Rect rect = GUILayoutUtility.GetLastRect ();
//			rect.position += new Vector2 (0, rect.height);
//			rect.size = new Vector2 (width, height);

			Rect rect = GUILayoutUtility.GetRect( width, height );
			rect.width = width;

			float progressPerc = GetProgressPerc ();
			GUIUtils.DrawBar( rect, progressPerc, new Vector4(149, 185, 244, 255) / 256.0f, new Vector4(92, 147, 237, 255) / 256.0f, 2f );

		}

    }
}

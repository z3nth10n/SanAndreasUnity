﻿using System.IO;
using System.Linq;
using SanAndreasUnity.Importing.Animation;
using SanAndreasUnity.Importing.Archive;
using SanAndreasUnity.Importing.Collision;
using SanAndreasUnity.Importing.Items;
using SanAndreasUnity.Importing.Vehicles;
using SanAndreasUnity.Utilities;
using UnityEngine;

namespace SanAndreasUnity.Behaviours
{
    public class Loader : MonoBehaviour
    {
	//	public	bool	asynchronousLoad = false;

        public static bool HasLoaded { get; private set; }
		public	static	string	loadingStatusString {
			get { 
				string[] statuses = { "archive paths", "archive", "collision files", "item info",
					"handling info", "animation group info", "car colors" };
			
				return "Loading " + statuses [loadingStatus];
			}
		}
		private	static	int	loadingStatus = 0 ;
		private	static	string[]	archivePaths;
		private	static	IArchive[] archives;


        private void Awake()
        {
            if (HasLoaded) return;

			/*
			var archivePaths = Config.GetPaths ("archive_paths");

			IArchive[] archives;
			using (Utilities.Profiler.Start("Archive load time")) {
				archives = archivePaths.Select(x => 
					File.Exists(x) ? (IArchive) ArchiveManager.LoadImageArchive(x)
					: Directory.Exists(x) ? ArchiveManager.LoadLooseArchive(x)
					: null).Where(x => x != null).ToArray();
			}

			using (Utilities.Profiler.Start("Collision load time")) {
				foreach (var archive in archives) {
					foreach (var colFile in archive.GetFileNamesWithExtension(".col")) {
						CollisionFile.Load(colFile);
					}
				}
			}

			using (Utilities.Profiler.Start("Item info load time")) {
				foreach (var path in Config.GetPaths("item_paths")) {
					var ext = Path.GetExtension(path).ToLower();
					switch (ext) {
					case ".dat":
						Item.ReadLoadList(path); break;
					case ".ide":
						Item.ReadIde(path); break;
					case ".ipl":
						Item.ReadIpl(path); break;
					}
				}
			}

			using (Utilities.Profiler.Start("Handling info load time")) {
				Handling.Load(Config.GetPath("handling_path"));
			}

			using (Utilities.Profiler.Start("Animation group info load time")) {
				foreach (var path in Config.GetPaths("anim_groups_paths")) {
					AnimationGroup.Load(path);
				}
			}

			using (Utilities.Profiler.Start("Car color info load time")) {
				CarColors.Load(Config.GetPath("car_colors_path"));
			}

			HasLoaded = true;
			*/

        }

		void Update() {

			if (HasLoaded)
				return;


			switch (loadingStatus) {

			case 0:
				
				archivePaths = Config.GetPaths ("archive_paths");

				break;
			case 1:
				
				using (Utilities.Profiler.Start ("Archive load time")) {
					archives = archivePaths.Select (x => 
						File.Exists (x) ? (IArchive)ArchiveManager.LoadImageArchive (x)
						: Directory.Exists (x) ? ArchiveManager.LoadLooseArchive (x)
						: null).Where (x => x != null).ToArray ();
				}

				break;
			case 2:

				using (Utilities.Profiler.Start ("Collision load time")) {
					foreach (var archive in archives) {
						foreach (var colFile in archive.GetFileNamesWithExtension(".col")) {
							CollisionFile.Load (colFile);
						}
					}
				}

				break;
			case 3:

				using (Utilities.Profiler.Start ("Item info load time")) {
					foreach (var path in Config.GetPaths("item_paths")) {
						var ext = Path.GetExtension (path).ToLower ();
						switch (ext) {
						case ".dat":
							Item.ReadLoadList (path);
							break;
						case ".ide":
							Item.ReadIde (path);
							break;
						case ".ipl":
							Item.ReadIpl (path);
							break;
						}
					}
				}

				break;
			case 4:

				using (Utilities.Profiler.Start ("Handling info load time")) {
					Handling.Load (Config.GetPath ("handling_path"));
				}

				break;
			case 5:

				using (Utilities.Profiler.Start ("Animation group info load time")) {
					foreach (var path in Config.GetPaths("anim_groups_paths")) {
						AnimationGroup.Load (path);
					}
				}

				break;
			case 6:

				using (Utilities.Profiler.Start ("Car color info load time")) {
					CarColors.Load (Config.GetPath ("car_colors_path"));
				}

				HasLoaded = true;

				break;

			}

			loadingStatus++;


		}

		void	OnGUI() {

			if (HasLoaded)
				return;

			// display loading progress

			GUILayout.BeginHorizontal ();
			GUILayout.FlexibleSpace ();
			GUILayout.Label ("<size=25>" + loadingStatusString + "</size>");
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

		}


	}

}

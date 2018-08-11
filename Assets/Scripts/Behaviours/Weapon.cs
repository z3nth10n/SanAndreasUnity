﻿using SanAndreasUnity.Importing.Conversion;
using SanAndreasUnity.Importing.Items;
using SanAndreasUnity.Importing.Items.Definitions;
using SanAndreasUnity.Importing.Weapons;
using SanAndreasUnity.Utilities;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using SanAndreasUnity.Importing.Animation;
using System.Reflection;

namespace SanAndreasUnity.Behaviours
{
	public static class WeaponSlot
	{
		public static readonly int Hand = 0,
		Melee = 1,
		Pistol = 2,
		Shotgun = 3,
		Submachine = 4, // uzi, mp5, tec9
		Machine = 5, // ak47, m4
		Rifle = 6,
		Heavy = 7, // rocket launcher, flame thrower, minigun
		SatchelCharge = 8,
		Misc = 9, // spraycan, extinguisher, camera
		Misc2 = 10, // dildo, vibe, flowers, cane
		Special = 11, // parachute, goggles
		Detonator = 12,

		Count = 13;
	}

	public static class WeaponId
	{
		
		public static readonly int Pistol = 346;
		public static readonly int PistolSilenced = 347;
		public static readonly int DesertEagle = 348;

		public static readonly int Shotgun = 349;
		public static readonly int SawnOff = 350;
		public static readonly int SPAS12 = 351;

		public static readonly int MicroUzi = 352;
		public static readonly int Tec9 = 372;
		public static readonly int MP5 = 353;

		public static readonly int AK47 = 355;
		public static readonly int M4 = 356;

		public static readonly int CountryRifle = 357;
		public static readonly int SniperRifle = 358;

		public static readonly int RocketLauncher = 359;
		public static readonly int RocketLauncherHS = 360;
		public static readonly int FlameThrower = 361;
		public static readonly int MiniGun = 362;

	}

//	public class WeaponData
//	{
//		public string type = "";
//		public string fireType = "";
//		public float targetRange = 0;
//		public float weaponRange = 0;
//		public int modelId = -1;
//		public int slot = -1;
//		public AnimGroup animGroup = AnimGroup.None;
//		public int clipCapacity = 0;
//		public int damage = 0;
//	}

	public class Weapon : MonoBehaviour
	{
		private WeaponDef definition = null;
		public WeaponDef Definition { get { return this.definition; } }

		private WeaponData data = null;
		public WeaponData Data { get { return this.data; } }

		private	WeaponData.GunAimingOffset gunAimingOffset;
		public WeaponData.GunAimingOffset GunAimingOffset { get { return this.gunAimingOffset; } }

		public int SlotIndex { get { return this.Data.weaponslot; } }

	//	public int totalAmmo = 0;
	//	public int ammoInClip = 0;

		public Texture2D HudTexture { get; private set; }


		private static List<System.Type> s_weaponTypes = new List<System.Type> ();

		private static GameObject s_weaponsContainer = null;

		public static Texture2D CrosshairTexture { get; set; }
		public static Texture2D FistTexture { get; set; }

		public AnimationState AimAnimState { get; protected set; }
		private	float	m_aimAnimTimeForAimWithArmWeapon = 0f;
		//public bool IsInsideFireAnim { get { return this.AimAnimState != null && this.AimAnimState.enabled && this.AimAnimState.time > this.AimAnimMaxTime; } }
		public Transform GunFlash { get; private set; }



		static Weapon ()
		{
			// obtain all weapon types
			var myType = typeof (Weapon);
			foreach (Assembly a in System.AppDomain.CurrentDomain.GetAssemblies())
			{
				s_weaponTypes.AddRange (a.GetTypes ().Where (t => t.IsSubclassOf (myType)));
			}

		}


		public static Weapon Load (int modelId)
		{
			WeaponDef def = Item.GetDefinition<WeaponDef> (modelId);
			if (null == def)
				return null;

			WeaponData weaponData = WeaponData.LoadedWeaponsData.FirstOrDefault (wd => wd.modelId1 == def.Id);
			if (null == weaponData)
				return null;

			var geoms = Geometry.Load (def.ModelName, def.TextureDictionaryName);
			if (null == geoms)
				return null;

			if (null == s_weaponsContainer) {
				s_weaponsContainer = new GameObject ("Weapons");
			//	weaponsContainer.SetActive (false);
			}

			GameObject go = new GameObject (def.ModelName);
			go.transform.SetParent (s_weaponsContainer.transform);

			geoms.AttachFrames (go.transform, MaterialFlags.Default);

			Weapon weapon = AddWeaponComponent (go, weaponData);
			weapon.definition = def;
			weapon.data = weaponData;
			// cache gun aiming offset
			if (weapon.data.gunData != null)
				weapon.gunAimingOffset = weapon.data.gunData.aimingOffset;

			// load hud texture
			try {
				weapon.HudTexture = TextureDictionary.Load( def.TextureDictionaryName ).GetDiffuse( def.TextureDictionaryName + "icon" ).Texture;
			} catch {
				Debug.LogErrorFormat ("Failed to load hud icon for weapon: model {0}, txd {1}", def.ModelName, def.TextureDictionaryName);
			}

			return weapon;
		}

		private static Weapon AddWeaponComponent (GameObject go, WeaponData data)
		{
			// find type which inherits Weapon class, and whose name matches the one in data

			string typeName = data.weaponType.Replace ("_", "");

			var type = s_weaponTypes.Where (t => 0 == string.Compare (t.Name, typeName, true)).FirstOrDefault ();

			if (type != null) {
				return (Weapon)go.AddComponent (type);
			} else {
				return go.AddComponent<Weapon> ();
			}

		}


		public bool HasFlag( GunFlag gunFlag ) {

			if (this.data != null && this.data.gunData != null)
				return this.data.gunData.HasFlag (gunFlag);

			return false;
		}


		protected virtual void Awake ()
		{
			this.GunFlash = this.transform.FindChildRecursive("gunflash");
		}

		protected virtual void Start ()
		{

		}

		protected virtual void Update ()
		{
			
		}


		public virtual bool CanSprintWithIt {
			get {
				if (this.HasFlag (GunFlag.AIMWITHARM))
					return true;

				if (this.SlotIndex == WeaponSlot.Heavy || this.SlotIndex == WeaponSlot.Machine || this.SlotIndex == WeaponSlot.Rifle
				   || this.SlotIndex == WeaponSlot.Shotgun)
					return false;

				return true;
			}
		}

		public virtual AnimId IdleAnim {
			get {
				if (this.HasFlag (GunFlag.AIMWITHARM)) {
					return new AnimId (AnimGroup.WalkCycle, AnimIndex.Idle);
				} else {
					return new AnimId (AnimGroup.MyWalkCycle, AnimIndex.IdleArmed);
				}
			}
		}

		public virtual AnimId WalkAnim {
			get {
				if (this.HasFlag (GunFlag.AIMWITHARM)) {
					return new AnimId (AnimGroup.WalkCycle, AnimIndex.Walk);
				} else {
					return new AnimId (AnimGroup.Gun, AnimIndex.WALK_armed);
				}
			}
		}

		public virtual AnimId RunAnim {
			get {
				if (this.HasFlag (GunFlag.AIMWITHARM)) {
					return new AnimId (AnimGroup.WalkCycle, AnimIndex.Run);
				} else {
					return new AnimId (AnimGroup.Gun, AnimIndex.run_armed);
				}
			}
		}

		public virtual AnimId AimAnim {
			get {
				return new AnimId (AnimGroup.Rifle, AnimIndex.RIFLE_fire);
			}
		}

		public virtual float AimAnimMaxTime {
			get {
				return Weapons.WeaponsManager.ConvertAnimTime (this.data.gunData.animLoopStart);
			}
		}

		public virtual float AimAnimFireMaxTime {
			get {
				return Weapons.WeaponsManager.ConvertAnimTime (this.data.gunData.animLoopEnd);
			}
		}

		public virtual float GunFlashDuration {
			get {
				return Weapons.WeaponsManager.Instance.GunFlashDuration;
			}
		}

		public virtual void UpdateAnimWhileAiming (Player player)
		{
			var CurrentWeapon = this;
			var PlayerModel = player.PlayerModel;


		//	this.Play2Animations (new int[]{ 41, 51 }, new int[]{ 2 }, AnimGroup.MyWalkCycle,
		//		AnimGroup.MyWalkCycle, AnimIndex.IdleArmed, AnimIndex.GUN_STAND);

			if (CurrentWeapon.HasFlag (GunFlag.AIMWITHARM)) {
				// aim with arm
				// eg: pistol, tec9, sawnoff

//					var state = PlayerModel.PlayAnim (AnimGroup.Colt45, AnimIndex.colt45_fire);
//					state.wrapMode = WrapMode.ClampForever;
//					if (state.normalizedTime > m_aimWithArmMaxAnimTime)
//						state.normalizedTime = m_aimWithArmMaxAnimTime;

				PlayerModel.PlayAnim (AnimGroup.WalkCycle, AnimIndex.Idle);
				//state.RemoveMixingTransform (PlayerModel.Spine);

				// update fire state

				m_aimAnimTimeForAimWithArmWeapon += Time.deltaTime;

				if (player.WeaponHolder.NumFramesSinceStartedAiming <= 1 || player.WeaponHolder.NumFramesSinceSwitchedWeapon <= 1) {
					m_aimAnimTimeForAimWithArmWeapon = 0f;
				}

				if (m_aimAnimTimeForAimWithArmWeapon > this.AimAnimMaxTime) {

					if (player.WeaponHolder.IsFiring) {
						
						// check if anim reached end
						if(m_aimAnimTimeForAimWithArmWeapon >= this.AimAnimFireMaxTime) {
							// anim reached end, revert it to start

							m_aimAnimTimeForAimWithArmWeapon = this.AimAnimMaxTime;

							// no longer firing
							player.WeaponHolder.IsFiring = false;
						}
					} else {
						// check if we should start firing

						if (player.WeaponHolder.IsFireOn) {
							// we should start firing
							player.WeaponHolder.IsFiring = true;
						} else {
							// we should remain in aim state
							m_aimAnimTimeForAimWithArmWeapon = this.AimAnimMaxTime;
						}
					}

				}


				// rotate right upper arm to match direction of player
				// we'll need a few adjustments, because arm's right vector is player's forward vector,
				// and arm's forward vector is player's down vector => arm's up is player's left
				Vector3 lookAtPos = player.transform.position - player.transform.up * 500;
				Vector3 dir = -player.transform.right;
				PlayerModel.RightUpperArm.LookAt( lookAtPos, dir);
				// also rotate right hand
				PlayerModel.RightHand.LookAt (lookAtPos, dir);

			} else {

				//	PlayerModel.PlayUpperLayerAnimations (AnimGroup.Rifle, AnimGroup.WalkCycle, AnimIndex.RIFLE_fire, AnimIndex.Idle);

				AnimationState state = null;

				if (player.IsRunning && player.Movement.sqrMagnitude > float.Epsilon) {
					// walk and aim at the same time

					float angle = Vector3.Angle (player.Movement, player.transform.forward);

					if (angle > 110) {
						// move backward
						PlayerModel.Play2Anims( this.AimAnim, new AnimId(AnimGroup.Gun, AnimIndex.GunMove_BWD) );
					} else if (angle > 70) {
						// strafe - move left/right
						float rightAngle = Vector3.Angle( player.Movement, player.transform.right );
						if (rightAngle > 90) {
							// left
							PlayerModel.Play2Anims( this.AimAnim, new AnimId(AnimGroup.Gun, AnimIndex.GunMove_L) );
						} else {
							// right
							PlayerModel.Play2Anims( this.AimAnim, new AnimId(AnimGroup.Gun, AnimIndex.GunMove_R) );
						}

						// we have to reset local position of root frame - for some reason, anim is changing position
					//	PlayerModel.RootFrame.transform.localPosition = Vector3.zero;
						Importing.Conversion.Animation.RemovePositionCurves( PlayerModel.LastSecondaryAnimState.clip, PlayerModel.Frames );

						PlayerModel.VelocityAxis = 0;
					} else {
						// move forward
						PlayerModel.Play2Anims( this.AimAnim, new AnimId(AnimGroup.Gun, AnimIndex.GunMove_FWD) );
					}

					PlayerModel.LastAnimState.wrapMode = WrapMode.ClampForever;
					state = PlayerModel.LastAnimState;

				} else {
					// just aim

					//state = PlayerModel.PlayAnim (this.AimAnim, true, false);
					PlayerModel.Play2Anims( this.AimAnim, this.IdleAnim );

					state = PlayerModel.LastAnimState;
					state.wrapMode = WrapMode.ClampForever;
				}

				AimAnimState = state;


				this.UpdateFireAnim (player, state);
			}

		}

		protected virtual void UpdateFireAnim (Player player, AnimationState state)
		{
			
			if (state.time > this.AimAnimMaxTime) {
				
				if (player.WeaponHolder.IsFiring) {
					state.enabled = true;

					// check if anim reached end
					if(state.time >= this.AimAnimFireMaxTime) {
						// anim reached end, revert it to start

						state.time = this.AimAnimMaxTime;
						player.AnimComponent.Sample ();

						// no longer firing
						player.WeaponHolder.IsFiring = false;
					}
				} else {
					// check if we should start firing

					if (player.WeaponHolder.IsFireOn) {
						// we should start firing
						player.WeaponHolder.IsFiring = true;
					} else {
						// we should remain in aim state
						state.time = this.AimAnimMaxTime;
						player.AnimComponent.Sample ();
						state.enabled = false;
					}
				}

			}

		}

		public virtual void UpdateAnimWhileHolding (Player player)
		{
			var CurrentWeapon = this;
			var PlayerModel = player.PlayerModel;

			if (player.IsRunning) {

				PlayerModel.PlayAnim (CurrentWeapon.RunAnim);

			} else if (player.IsWalking) {

				PlayerModel.PlayAnim (CurrentWeapon.WalkAnim);

			} else if (player.IsSprinting) {

				if (CurrentWeapon.CanSprintWithIt) {
					PlayerModel.PlayAnim (AnimGroup.MyWalkCycle, AnimIndex.sprint_civi);
				} else {
					PlayerModel.PlayAnim (CurrentWeapon.IdleAnim);
				}

			} else {
				// player is standing

				PlayerModel.PlayAnim (CurrentWeapon.IdleAnim);

			}

		}

		public virtual void EnableOrDisableGunFlash (Player player)
		{
			
			// enable/disable gun flash
			if (this.GunFlash != null) {
				
				bool shouldBeVisible = false;

				if (this.HasFlag (GunFlag.AIMWITHARM)) {
					shouldBeVisible = m_aimAnimTimeForAimWithArmWeapon.BetweenExclusive (this.AimAnimMaxTime, this.AimAnimMaxTime + this.GunFlashDuration);
				} else {

					if (AimAnimState != null && AimAnimState.enabled) {
						// aim anim is being played

						if (AimAnimState.time.BetweenExclusive (this.AimAnimMaxTime, this.AimAnimMaxTime + this.GunFlashDuration)) {
							// muzzle flash should be visible
							shouldBeVisible = true;
						}
					}
				}

				shouldBeVisible = shouldBeVisible && player.IsFiring;

				this.GunFlash.gameObject.SetActive (shouldBeVisible);
			}

		}

		public virtual void UpdateGunFlashRotation (Player player)
		{

			if (null == this.GunFlash)
				return;

			if (!this.GunFlash.gameObject.activeInHierarchy)
				return;

			float delta = Weapons.WeaponsManager.Instance.GunFlashRotationSpeed * Time.deltaTime;

			this.GunFlash.rotation *= Quaternion.AngleAxis (delta, Vector3.right);

		}

	}

}

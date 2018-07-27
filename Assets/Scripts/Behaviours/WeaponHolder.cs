﻿using System.Collections.Generic;
using UnityEngine;
using SanAndreasUnity.Importing.Animation;
using SanAndreasUnity.Importing.Weapons;
using System.Linq;

namespace SanAndreasUnity.Behaviours {
	
	public class WeaponHolder : MonoBehaviour {

		private	Player	m_player;
		public	Pedestrian	PlayerModel { get { return m_player.PlayerModel; } }
		public	Camera	Camera { get { return m_player.Camera; } }

		private	Weapon[]	weapons = new Weapon[(int)WeaponSlot.Count];

		private	int		currentWeaponSlot = -1;
		public	int		CurrentWeaponSlot { get { return this.currentWeaponSlot; } }
		public	bool	IsHoldingWeapon { get { return this.currentWeaponSlot > 0; } }

		public	bool	autoAddWeapon = false;

		public	bool	IsAimOn { get; set; }
		public	bool	IsAiming { get { return this.IsAimOn && this.IsHoldingWeapon && !m_player.IsInVehicle; } }

		public	Weapon	CurrentWeapon { get ; private set ; }
		private	Transform	CurrentWeaponTransform { get { return CurrentWeapon != null ? CurrentWeapon.transform : null; } }
        

		public Vector3 SpineOffset;

		public enum WeaponAttachType
		{
			None,
			RightHand,
			BothFingers
		}

		public	WeaponAttachType	weaponAttachType = WeaponAttachType.RightHand;

		[SerializeField]	[Range(0,1)]	private	float	m_aimWithRifleMaxAnimTime = 0.7f;
	//	[SerializeField]	[Range(0,1)]	private	float	m_aimWithArmMaxAnimTime = 1.0f;

		public	Vector3	cameraAimOffset = new Vector3 (0.7f, 0.2f, -1);

		public	bool	rotatePlayerInDirectionOfAiming = true;



        void Awake () {
			
			m_player = this.GetComponent<Player> ();

		}

		void OnLoaderFinished ()
		{
			if (this.autoAddWeapon)
			{
				this.AddRandomWeapons ();

				if (!this.IsHoldingWeapon)
				{
					this.SwitchWeapon (WeaponSlot.Pistol);
				}
			}
		}

		void Update () {

			if (!Loader.HasLoaded)
				return;


			// switch weapons
			if (GameManager.CanPlayerReadInput()) {

				if (Input.GetKeyDown (KeyCode.Q))
					this.SwitchWeapon (false);
				else if (Input.GetKeyDown (KeyCode.E))
					this.SwitchWeapon (true);
				
			}


			this.UpdateWeaponTransform ();


		}

		void LateUpdate()
		{
			// all things that manipulate skeleton must be placed in LateUpdate(), because otherwise Animator will
			// override them

			// order of these functions is important


			UpdateAnims ();

		//	RotatePlayerInDirectionOfAiming ();

			// this should be done AFTER the player has rotated in direction of aiming
			RotateSpine ();

			// this should be done after all other skeleton changes
			// idk why this boolean has to be checked - there are some race conditions with animations
			// - if we don't check it, weapons will start shaking
			if (this.IsAiming)
				UpdateWeaponTransform ();

		}


		private void UpdateAnims ()
		{

			if (!m_player.shouldPlayAnims)
				return;

			if (this.IsAiming) {
				// player is aiming
				// play appropriate anim

			//	this.Play2Animations (new int[]{ 41, 51 }, new int[]{ 2 }, AnimGroup.MyWalkCycle,
			//		AnimGroup.MyWalkCycle, AnimIndex.IdleArmed, AnimIndex.GUN_STAND);

				if (CurrentWeapon.HasFlag (GunFlag.AIMWITHARM)) {
                    // aim with arm
                    // ie: pistol, tec9, sawnoff
                    
//					var state = PlayerModel.PlayAnim (AnimGroup.Colt45, AnimIndex.colt45_fire);
//					state.wrapMode = WrapMode.ClampForever;
//					if (state.normalizedTime > m_aimWithArmMaxAnimTime)
//						state.normalizedTime = m_aimWithArmMaxAnimTime;

                    var state = PlayerModel.PlayAnim (AnimGroup.WalkCycle, AnimIndex.Idle);
					//state.RemoveMixingTransform (PlayerModel.Spine);

					// rotate right upper arm to match direction of player
					// we'll need a few adjustments, because arm's right vector is player's forward vector,
					// and arm's forward vector is player's down vector => arm's up is player's left
					Vector3 lookAtPos = m_player.transform.position - m_player.transform.up * 500;
					Vector3 dir = -m_player.transform.right;
					PlayerModel.RightUpperArm.LookAt( lookAtPos, dir);
					// also rotate right hand
					PlayerModel.RightHand.LookAt (lookAtPos, dir);

				} else {
					
				//	PlayerModel.PlayUpperLayerAnimations (AnimGroup.Rifle, AnimGroup.WalkCycle, AnimIndex.RIFLE_fire, AnimIndex.Idle);

					var state = PlayerModel.PlayAnim (AnimGroup.Rifle, AnimIndex.RIFLE_fire, true, true);
					state.wrapMode = WrapMode.ClampForever;
					if (state.normalizedTime > m_aimWithRifleMaxAnimTime) {
					//	state.normalizedTime = m_aimWithRifleMaxAnimTime;
						state.enabled = false;
					}
					
				}
			}

			if (!m_player.IsInVehicle && !this.IsAiming && this.IsHoldingWeapon) {
				// player is not aiming, but is holding a weapon
				// update current anim

				if (m_player.IsRunning) {

				//	Play2Animations (new int[] { 41, 51 }, new int[] { 2 }, AnimGroup.WalkCycle,
				//		AnimGroup.MyWalkCycle, AnimIndex.Run, AnimIndex.IdleArmed);

					if (CurrentWeapon.HasFlag (GunFlag.AIMWITHARM)) {
						PlayerModel.PlayAnim (AnimGroup.WalkCycle, AnimIndex.Run);
					} else {
						PlayerModel.PlayAnim (AnimGroup.Gun, AnimIndex.run_armed);
					}

				} else if (m_player.IsWalking) {

				//	Play2Animations (new int[] { 41, 51 }, new int[] { 2 }, AnimGroup.WalkCycle,
				//		AnimGroup.MyWalkCycle, AnimIndex.Walk, AnimIndex.IdleArmed);

					if (CurrentWeapon.HasFlag (GunFlag.AIMWITHARM)) {
						PlayerModel.PlayAnim (AnimGroup.WalkCycle, AnimIndex.Walk);
					} else {
						PlayerModel.PlayAnim (AnimGroup.Gun, AnimIndex.WALK_armed);
					}

				} else if (m_player.IsSprinting) {

					if (CurrentWeapon.HasFlag (GunFlag.AIMWITHARM)) {
						PlayerModel.PlayAnim (AnimGroup.MyWalkCycle, AnimIndex.sprint_civi);
					} else {
						PlayerModel.PlayAnim (AnimGroup.MyWalkCycle, AnimIndex.IdleArmed);
					}

				} else {
					// player is standing

				//	Play2Animations(new int[] { 41, 51 }, new int[] { 2 }, AnimGroup.MyWalkCycle,
				//		AnimGroup.MyWalkCycle, AnimIndex.IdleArmed, AnimIndex.IdleArmed);

					if (CurrentWeapon.HasFlag (GunFlag.AIMWITHARM)) {
						PlayerModel.PlayAnim (AnimGroup.WalkCycle, AnimIndex.Idle);
					} else {
						PlayerModel.PlayAnim (AnimGroup.MyWalkCycle, AnimIndex.IdleArmed);
					}

				}

			}

		}

		private void UpdateWeaponTransform ()
		{

			// update transform of weapon
			if (CurrentWeaponTransform != null) {

				if (this.weaponAttachType == WeaponAttachType.BothFingers) {
					if (PlayerModel.RightFinger != null && PlayerModel.LeftFinger != null) {

						CurrentWeaponTransform.transform.position = PlayerModel.RightFinger.transform.position;

						Vector3 dir = (PlayerModel.LeftFinger.transform.position - PlayerModel.RightFinger.transform.position).normalized;
						Quaternion q = Quaternion.LookRotation (dir, transform.up);
						Vector3 upNow = q * Vector3.up;
						dir = Quaternion.AngleAxis (-90, upNow) * dir;
						CurrentWeaponTransform.transform.rotation = Quaternion.LookRotation (dir, transform.up);
					}
				} else if (this.weaponAttachType == WeaponAttachType.RightHand) {
					if (PlayerModel.RightHand != null) {

						Vector3 weaponPos = PlayerModel.RightHand.position;
						Transform rotationTr = PlayerModel.RightHand;

						// add aim offset
						//	var aimOffset = CurrentWeapon.GunAimingOffset;
						//	if (aimOffset != null)
						//		weaponPos += rotationTr.forward * aimOffset.aimZ + rotationTr.right * aimOffset.aimX;

						CurrentWeaponTransform.transform.position = weaponPos;
						CurrentWeaponTransform.transform.rotation = rotationTr.rotation;
					}
				}

			}

		}

		private void RotateSpine ()
		{

			if (this.IsAiming)
			{
				PlayerModel.Spine.LookAt(Camera.transform.position + Camera.transform.forward * 500);

				Vector3 eulers = this.SpineOffset;
				if (this.CurrentWeapon.HasFlag (GunFlag.AIMWITHARM))
					eulers.y = 0;
				PlayerModel.Spine.Rotate (eulers);
			//	PlayerModel.ChangeSpineRotation (this.CurrentWeaponTransform.forward, Camera.transform.position + Camera.transform.forward * Camera.farClipPlane - this.CurrentWeaponTransform.position, SpineRotationSpeed, ref tempSpineLocalEulerAngles, ref targetRot, ref spineRotationLastFrame);
			}

		}

		public void RotatePlayerInDirectionOfAiming ()
		{

			if (!this.rotatePlayerInDirectionOfAiming)
				return;

			if (!this.IsAiming)
				return;

//			Vector3 lookAtPos = Camera.transform.position + Camera.transform.forward * 500;
//			lookAtPos.y = m_player.transform.position.y;
//
//			m_player.transform.LookAt (lookAtPos, Vector3.up);

			Vector3 forward = Camera.transform.forward;
			forward.y = 0;
			forward.Normalize ();
		//	m_player.transform.forward = forward;
			m_player.Heading = forward;

		}


		public void SwitchWeapon( bool next )
		{

			if (currentWeaponSlot < 0)
				currentWeaponSlot = 0;

			int delta = next ? 1 : -1;

			for (int i = currentWeaponSlot + delta, count = 0;
				i != currentWeaponSlot && count < weapons.Length;
				i += delta, count++) {

				if (i < 0)
					i = weapons.Length - 1;
				if (i >= weapons.Length)
					i = 0;

				if ( (int)WeaponSlot.Hand == i || weapons [i] != null ) {
					// this is a hand slot or there is a weapon in this slot
					// switch to it
					SwitchWeapon (i);
					break;
				}
			}

		}

        public void SwitchWeapon(WeaponSlot slot)
		{
			this.SwitchWeapon ((int)slot);
		}

		public void SwitchWeapon (int slotIndex)
		{
			if (slotIndex == currentWeaponSlot)
				return;

			if (CurrentWeapon != null) {
				// hide the weapon
				HideWeapon( CurrentWeapon );
			}

			if (slotIndex >= 0) {
				
				CurrentWeapon = weapons [slotIndex];

				// show the weapon
				if (CurrentWeapon != null)
					UnHideWeapon (CurrentWeapon);

			} else {
				CurrentWeapon = null;
			}

			currentWeaponSlot = slotIndex;
		}

		private static void HideWeapon (Weapon weapon)
		{
			weapon.gameObject.SetActive (false);
		}

		private static void UnHideWeapon (Weapon weapon)
		{
			weapon.gameObject.SetActive (true);
		}

		public void SetWeaponAtSlot (Importing.Items.Definitions.WeaponDef weaponDef, WeaponSlot slot)
		{
			this.SetWeaponAtSlot (weaponDef.Id, slot);
		}

		public void SetWeaponAtSlot (int weaponId, WeaponSlot slot)
		{
			this.SetWeaponAtSlot (weaponId, (int)slot);
		}

		public void SetWeaponAtSlot (int weaponId, int slotIndex)
		{
			
			// destroy current weapon at this slot
			if (weapons [slotIndex] != null) {
				Destroy (weapons [slotIndex].gameObject);
			}

			weapons [slotIndex] = Weapon.Load (weaponId);

			if (slotIndex == currentWeaponSlot) {
				// update current weapon variable
				CurrentWeapon = weapons [slotIndex];
			} else {
				// hide the newly created weapon
				HideWeapon (weapons[slotIndex]);
			}

		}

		public void RemoveAllWeapons() {

			this.SwitchWeapon (-1);

			for (int i = 0; i < this.weapons.Length; i++) {
				if (this.weapons [i] != null)
					Destroy (this.weapons [i].gameObject);
				this.weapons [i] = null;
			}

		}


		public void AddRandomWeapons ()
		{

			WeaponSlot[] slots = new WeaponSlot[] { WeaponSlot.Pistol, WeaponSlot.Shotgun, WeaponSlot.Submachine,
				WeaponSlot.Machine, WeaponSlot.Rifle, WeaponSlot.Heavy
			};

			var groups = WeaponData.LoadedWeaponsData.Where( wd => slots.Contains( (WeaponSlot) wd.weaponslot ) )
				.GroupBy( wd => wd.weaponslot );

			foreach (var grp in groups) {

				int count = grp.Count ();
				if (count < 1)
					continue;

				int index = Random.Range (0, count - 1);
				WeaponData chosenWeaponData = grp.ElementAt (index);

				this.SetWeaponAtSlot (chosenWeaponData.modelId1, grp.Key);
			}

		}


		void OnDrawGizmosSelected ()
		{
			// draw ray from gun

			if (CurrentWeapon != null) {
				Gizmos.color = Color.red;
				Gizmos.DrawRay (CurrentWeaponTransform.position, CurrentWeaponTransform.forward);
			}

		}

	}

}

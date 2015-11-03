//========= Copyright 2015, Valve Corporation, All rights reserved. ===========
//
// Purpose: Enables/disables left and right controller objects based on
// connectivity and relative positions.
//
//=============================================================================

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Valve.VR;

public class SteamVR_ControllerManager : MonoBehaviour
{
	public GameObject left, right;

	int leftIndex = -1, rightIndex = -1;
	List<int> unassigned = new List<int>();

	void OnEnable()
	{
		if (left != null)
			left.SetActive(false);

		if (right != null)
			right.SetActive(false);

		for (int i = 0; i < SteamVR.connected.Length; i++)
			if (SteamVR.connected[i])
				OnDeviceConnected(i, true);

		SteamVR_Utils.Event.Listen("input_focus", OnInputFocus);
		SteamVR_Utils.Event.Listen("device_connected", OnDeviceConnected);
	}

	void OnDisable()
	{
		SteamVR_Utils.Event.Remove("input_focus", OnInputFocus);
		SteamVR_Utils.Event.Remove("device_connected", OnDeviceConnected);
	}

	// Hide controllers when the dashboard is up.
	private void OnInputFocus(params object[] args)
	{
		bool hasFocus = (bool)args[0];
		if (hasFocus)
		{
			if (left != null)
				ShowObject(left.transform, "hidden (left)");
			if (right != null)
				ShowObject(right.transform, "hidden (right)");
		}
		else
		{
			if (left != null)
				HideObject(left.transform, "hidden (left)");
			if (right != null)
				HideObject(right.transform, "hidden (right)");
		}
	}

	// Reparents to a new object and deactivates that object (this allows
	// us to call SetActive in OnDeviceConnected independently.
	private void HideObject(Transform t, string name)
	{
		var hidden = new GameObject(name).transform;
		hidden.parent = t.parent;
		t.parent = hidden;
		hidden.gameObject.SetActive(false);
	}
	private void ShowObject(Transform t, string name)
	{
		var hidden = t.parent;
		if (hidden.gameObject.name != name)
			return;
		t.parent = hidden.parent;
		Object.Destroy(hidden.gameObject);
	}

	private void OnDeviceConnected(params object[] args)
	{
		var index = (int)args[0];

		if (index == leftIndex)
		{
			if (left != null)
				left.SetActive(false);

			leftIndex = -1;
		}

		if (index == rightIndex)
		{
			if (right != null)
				right.SetActive(false);

			rightIndex = -1;
		}

		if (unassigned.Remove(index) && unassigned.Count == 0)
			StopAllCoroutines();

		var vr = SteamVR.instance;
		if (vr.hmd.GetTrackedDeviceClass((uint)index) == TrackedDeviceClass.Controller)
		{
			var connected = (bool)args[1];
			if (connected)
			{
				unassigned.Add(index);
				if (unassigned.Count == 1)
					StartCoroutine(FindControllers());
			}
		}
	}

	IEnumerator FindControllers()
	{
		while (true)
		{
			// If only have one controller to assign, wait until it starts tracking, then assign as the right controller.
			if (leftIndex == -1 && rightIndex == -1 && unassigned.Count == 1)
			{
				var index = unassigned[0];
				if (SteamVR_Controller.Input(index).hasTracking)
				{
					rightIndex = index;
					unassigned.Remove(index);

					if (right != null)
					{
						right.SetActive(true);
						right.BroadcastMessage("SetDeviceIndex", rightIndex, SendMessageOptions.DontRequireReceiver);
					}

					break; // done
				}
			}
			else
			{
				// More than one, find leftmost and rightmost controllers and assign them.
				var hmd = SteamVR_Controller.Input((int)OpenVR.k_unTrackedDeviceIndex_Hmd);
				if (hmd.hasTracking)
				{
					int minIndex = -1, maxIndex = -1;
					float minScore = float.MaxValue, maxScore = -float.MaxValue;

					var invXform = hmd.transform.GetInverse();
					if (leftIndex != -1)
					{
						var device = SteamVR_Controller.Input(leftIndex);
						if (device.hasTracking)
						{
							var score = CalcAngle(invXform * device.transform.pos);
							if (score < minScore)
							{
								minScore = score;
								minIndex = leftIndex;
							}
							if (score > maxScore)
							{
								maxScore = score;
								maxIndex = leftIndex;
							}
						}
					}
					if (rightIndex != -1)
					{
						var device = SteamVR_Controller.Input(rightIndex);
						if (device.hasTracking)
						{
							var score = CalcAngle(invXform * device.transform.pos);
							if (score < minScore)
							{
								minScore = score;
								minIndex = rightIndex;
							}
							if (score > maxScore)
							{
								maxScore = score;
								maxIndex = rightIndex;
							}
						}
					}
					foreach (var index in unassigned)
					{
						var device = SteamVR_Controller.Input(index);
						if (device.hasTracking)
						{
							var score = CalcAngle(invXform * device.transform.pos);
							if (score < minScore)
							{
								minScore = score;
								minIndex = index;
							}
							if (score > maxScore)
							{
								maxScore = score;
								maxIndex = index;
							}
						}
					}

					// Identified both controllers, (re)assign them.
					if (minIndex != maxIndex)
					{
						rightIndex = minIndex;
						unassigned.Remove(rightIndex);

						if (right != null)
						{
							right.SetActive(true);
							right.BroadcastMessage("SetDeviceIndex", rightIndex, SendMessageOptions.DontRequireReceiver);
						}

						leftIndex = maxIndex;
						unassigned.Remove(leftIndex);

						if (left != null)
						{
							left.SetActive(true);
							left.BroadcastMessage("SetDeviceIndex", leftIndex, SendMessageOptions.DontRequireReceiver);
						}

						break; // done
					}
					else if (minIndex != -1)
					{
						// Only found one, assign it if necessary, but keep looking.
						if (minIndex != leftIndex && minIndex != rightIndex)
						{
							rightIndex = minIndex;
							unassigned.Remove(rightIndex);

							if (right != null)
							{
								right.SetActive(true);
								right.BroadcastMessage("SetDeviceIndex", rightIndex, SendMessageOptions.DontRequireReceiver);
							}
						}
					}
				}
			}

			yield return null; // try again next frame
		}
	}

	float CalcAngle(Vector3 pos)
	{
		var dir = new Vector3(pos.x, 0.0f, pos.z).normalized;
		var dot = Vector3.Dot(dir, Vector3.forward);
		var cross = Vector3.Cross(dir, Vector3.forward);
		return (cross.y > 0.0f) ? 2.0f - dot : dot;
	}
}


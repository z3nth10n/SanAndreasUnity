using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public Transform MuzzleTransform;
    public SteamVR_TrackedObject Controller;

    public GameObject AttackEffect;
    public GameObject BulletPrefab;

    public AudioClip ShootSound;
    public AudioSource AudioSource;

    private SteamVR_Controller.Device _controllerDevice;
    
    private void UpdateWithValidDevice(SteamVR_Controller.Device device)
    {
        if (device.GetHairTriggerDown())
        {
            StartCoroutine(Attack());
        }
    }

    private IEnumerator Attack()
    {
        AudioSource.pitch = Random.value * 0.1f + 0.95f;
        AudioSource.PlayOneShot(ShootSound, Random.value * 0.25f + 0.75f);

        Bullet.Fire(BulletPrefab, MuzzleTransform, 1f/32f);

        var effect = Instantiate(AttackEffect);
        effect.transform.SetParent(MuzzleTransform, false);
        effect.SetActive(true);
        
        yield return new WaitForSeconds(2f);

        Destroy(effect);
    }
    
    void Update()
    {
        if (_controllerDevice != null)
        {
            UpdateWithValidDevice(_controllerDevice);
            return;
        }

        if (!Controller.isValid) return;
        _controllerDevice = SteamVR_Controller.Input((int) Controller.index);
        Controller.GetComponent<MeshRenderer>().enabled = false;
    }
}

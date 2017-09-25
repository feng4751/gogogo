using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	public float damage = 10f;
	public float range = 100f;

	public PlayerGun go;
	public Camera fpsCam;
	public ParticleSystem muzzleFlash;
	public AudioClip so;
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) 
		{
			Shoot ();
			go.ammo--;
			GetComponent<AudioSource> ().PlayOneShot (so);
		}
	}

	void Shoot()
	{
		muzzleFlash.Play();
		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) 
		{
			Debug.Log (hit.transform.name);
			Target target = hit.transform.GetComponent<Target>();
			if (target != null) 
			{
				target.TakeDamage (damage);
			}

            Target2 target2 = hit.transform.GetComponent<Target2>();
            if (target2 != null)
            {
                target2.TakeDamage(damage);
            }
        }
	}




}

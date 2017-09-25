using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public PlayerGun pg;
	public AudioClip clip;

	void OnTriggerEnter(Collider other){
		pg.hasGun = true;
		GetComponent<AudioSource> ().PlayOneShot (clip);
	}
}

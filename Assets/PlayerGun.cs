using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGun : MonoBehaviour {
	public bool hasGun;
	public GameObject imageObject;
	public GameObject imageObject2;
	public GameObject imageObject3;
	public GameObject imageObject4;
	public GameObject imageObject5;
	public int ammo = 100;
	public Text txt;
	public Text txt2;
	// Use this for initialization
	void Start () {
		hasGun = false;
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "" + ammo;
		txt2.color = Color.red;
		if (hasGun) 
		{
			imageObject.SetActive (true);

			imageObject3.SetActive (true);

			imageObject4.SetActive (true);

			imageObject5.SetActive (false);

			Destroy (imageObject2, 0.5f);
				

		}
	}
}

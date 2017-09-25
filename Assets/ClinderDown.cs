using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClinderDown : MonoBehaviour {

	public GameObject player;
	public GameObject Axe;
	public GameObject text;
	public Text txt;
	bool open = false;
	// Use this for initialization
	void Start () {

	}



	// Update is called once per frame
	void Update () {
		txt.color = Color.red;
		if (Vector3.Distance (player.transform.position, gameObject.transform.position) < 3f) {
			open=true;
		}
		if (open) {
			transform.Translate (0,-Time.deltaTime/2,0);
			Axe.SetActive (false);
			text.SetActive (true);
			Destroy (text, 4f);
		}
	}
}

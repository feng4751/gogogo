using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoTrigger : MonoBehaviour {
	public GameObject player;
	public GameObject mao;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.transform.position, gameObject.transform.position) < 1f) {

			mao.SetActive (true);

			Destroy (mao,2f);
		}
	}
}

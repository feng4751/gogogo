using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {
	public GameObject player;
	public OpenSesame door;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bool playerHasKey = player.GetComponent<GetKey> ().hasGoldKey;
		if (Vector3.Distance (player.transform.position, gameObject.transform.position) < 1f && playerHasKey) {

			door.moveDown ();
		}
	}
		

}

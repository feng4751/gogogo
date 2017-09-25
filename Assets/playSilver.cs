using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSilver : MonoBehaviour {

	public GetKey playerGetkey;
	public GameObject player;

	void Update(){
		if (Vector3.Distance (player.transform.position, gameObject.transform.position) < 1f) {

			playerGetkey.KeyGot1();
			Destroy (gameObject,0.5f);
		}
	}
}

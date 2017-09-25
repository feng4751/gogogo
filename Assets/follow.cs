using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public Transform player;
	// Update is called once per frame
	void Update () {
        transform.LookAt(player);
        transform.Translate(Vector3.forward*Time.deltaTime);
	
	}
}

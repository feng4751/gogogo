using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour {

	public bool hasGoldKey = false;
	public bool hasSilverKey = false;

	public void KeyGot(){
		hasGoldKey = true;
	}
	public void KeyGot1(){
		hasSilverKey = true;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

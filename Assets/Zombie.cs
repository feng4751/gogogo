using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour {
    public Transform player;
    public float dist;
    bool stay;
	void Start(){

        stay = true;
        GetComponent<Animator>().SetBool("stay", true);

    }
	// Update is called once per frame
	void Update () {
        NavMeshAgent nm = GetComponent<NavMeshAgent>();
        float dist = Vector3.Distance(player.transform.position, gameObject.transform.position);
        if (dist < 5 && stay)
        {
            GetComponent<Animator>().SetBool("isWalk", true);
            GetComponent<Animator>().SetBool("stay", false);
            stay = false;

        }

        if (dist > 2 && stay == false) {
            GetComponent<Animator>().SetBool("Walk", true);
            nm.Resume();
            nm.SetDestination(player.position);
        }
        else
        {
            GetComponent<Animator>().SetBool("Walk", false);
            nm.Stop();
        }
    }
}

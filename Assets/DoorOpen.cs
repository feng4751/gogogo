using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    public GameObject player;
    public GameObject Clinder1;
    public GameObject Clinder2;
    public OpenSesame door;
    public GameObject text;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) < 2f )
        {
            Destroy(Clinder1, 0.5f);
            Destroy(Clinder2, 0.5f);
            Destroy(text, 0.5f);
            door.moveDown();
        }
    }
}

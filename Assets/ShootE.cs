using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootE : MonoBehaviour {
    
    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    public float countdown = -1;

    void Update()
    {
        
            Fire();
        
    }
    void Fire()
    {
        countdown -= Time.deltaTime;
        if (countdown < 0) {
            countdown = 0.5f;
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);
        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 7;
        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
    }
}




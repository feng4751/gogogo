using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target2 : MonoBehaviour {

    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();

        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
	public void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene ("2",LoadSceneMode.Single);

	}

}

using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public float counter = 1;

    public float time = 0;

    // Update is called once per frame
    void Update()
    {
        if (time > 120)
        {
            counter = -1;
        }
        if (time < 0)
        {
            counter = 1;
        }

        time = time + counter;
        transform.Translate(Vector3.forward * Time.deltaTime * 1 * counter);

    }
}

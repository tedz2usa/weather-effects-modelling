using UnityEngine;
using System.Collections;

public class MyEmitter : MonoBehaviour {

    public GameObject sphere;

	// Use this for initialization
	void Start () {

        int numObjects = 20;
        int bounds = 20;

        for (int i = 0; i < numObjects; i++)
        {
            float x = Random.Range(-bounds, bounds);
            float z = Random.Range(-bounds, bounds);
            float y = 2;

            Instantiate(sphere.gameObject, new Vector3(x, y, z), Quaternion.identity);
        }

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

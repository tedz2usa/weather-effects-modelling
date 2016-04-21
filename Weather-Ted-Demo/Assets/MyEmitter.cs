using UnityEngine;
using System.Collections;

public class MyEmitter : MonoBehaviour {

    public GameObject sphere;
    private int counter = 10;
    private int numObjects = 20;
    private int bounds = 30;

    // Use this for initialization
    void Start () {

        

        

        

	
	}
	
	// Update is called once per frame
	void Update () {

        counter--;
        if (counter < 0)
        {
            for (int i = 0; i < numObjects; i++)
            {
                float x = Random.Range(-bounds, bounds);
                float z = Random.Range(-bounds, bounds);
                float y = 2;

                Instantiate(sphere.gameObject, new Vector3(x, y, z), Quaternion.identity);
            }

            counter = 10;
        }

	}
}

using UnityEngine;
using System.Collections;

public class MyParticle : MonoBehaviour {

    private Rigidbody rb;

    public static Vector3 vortextCenter = Vector3.zero;
    public static float vortexHeight = 10;

    private static int nextID = 1;
    private int id;
    private int counter;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        id = nextID;
        nextID++;
        counter = 10;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 towardsCenter = Vector3.Normalize(vortextCenter - transform.position);

        Vector3 towardsCenterForce = towardsCenter * 8;

        Vector3 tangential = Vector3.Normalize(Vector3.Cross(towardsCenter, Vector3.up));

        Vector3 tangentialForce = tangential * 2f;

        Vector3 upwardsForce = Vector3.up * Random.Range(11, 40);//Mathf.Abs(10 - transform.position.y);

        
        Vector3 force = towardsCenterForce + tangentialForce + upwardsForce;

        if (id == 2)
        {
            counter--;
            if (counter < 0)
            {
                Debug.Log("towardsCenterForce: " + towardsCenterForce);
                Debug.Log("tangentialForce: " + tangentialForce);
                Debug.Log("upwardsForce: " + upwardsForce);
                Debug.Log("Sum: " + force);
                counter = 10;
            }
            
        }
        

        rb.AddForce(force);

    }
}

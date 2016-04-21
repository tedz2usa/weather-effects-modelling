using UnityEngine;
using System.Collections;

public class MyParticle : MonoBehaviour {

    private Rigidbody rb;

    public static Vector3 vortextCenter = Vector3.zero;
    public static float vortexHeight = 10;

    private static int nextID = 1;
    private int id;
    private int counter;

    private float lifetime = 0;
    static bool printed = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        id = nextID;
        nextID++;
        counter = 10;
        transform.localScale = Vector3.one * Random.Range(1.5f, 2.5f);
        


    }
	
	// Update is called once per frame

	void FixedUpdate () {

        lifetime += Time.fixedDeltaTime;
        if (lifetime > 20)
        {
            Destroy(this.gameObject);
        }

        Vector3 towardsCenter = Vector3.Normalize(vortextCenter - transform.position);

        Vector3 towardsCenterForce = towardsCenter * 10;

        Vector3 tangential = Vector3.Normalize(Vector3.Cross(towardsCenter, Vector3.up));

        Vector3 tangentialForce = tangential * 4f;

        Vector3 upwardsForce = Vector3.up * Random.Range(18, 25);

        
        Vector3 force = towardsCenterForce + tangentialForce + upwardsForce;
        
        rb.AddForce(force);

    }




}




//if (id == 2)
//{
//    counter--;
//    if (counter < 0)
//    {
//        //Debug.Log("towardsCenterForce: " + towardsCenterForce);
//        //Debug.Log("tangentialForce: " + tangentialForce);
//        //Debug.Log("upwardsForce: " + upwardsForce);
//        //Debug.Log("linearBias: " + MylinearBias);
//        //Debug.Log("Sum: " + force);
//        counter = 10;
//    }

//}


//public static float linearBias(float value, float begin, float end)
//{
//    float length = (end - begin);
//    float middle = length / 2;
//    float distanceToMiddle = Mathf.Abs(value - middle);
//    return 1 - distanceToMiddle / middle * 0.95f;
//}


//if (!printed)
//{

//    Debug.Log("print");

//    float i = 0;
//    while( i < 200)
//    {
//        float bias = linearBias(i, 0, 200);
//        Debug.Log("bias(" + i + ") = " + bias);
//        i += 0.5f;
//    }

//    printed = true;

//}
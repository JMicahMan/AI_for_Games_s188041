using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderBehaviour : MonoBehaviour {
    public float focusTime = 2.0f;
    public float Speed;
    public Vector3 refDir;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        var point = Random.insideUnitSphere;


        focusTime -= Time.deltaTime;
        Vector3 dir = point - transform.position;
        refDir = dir;

        if (focusTime < 0)
        {
            transform.forward = dir;
            focusTime = 2.0f;
        }
        transform.position += transform.forward * (Time.deltaTime * Speed);


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekBehaviour : MonoBehaviour {


    public GameObject Goal;

    public float Speed;



	void Start () {
		
	}
	
	void Update ()
    {
        Vector3 Direction = Goal.transform.position - transform.position;
        transform.forward = Direction.normalized;
        transform.position += Direction * (Time.deltaTime * Speed);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArriveBehaviour : MonoBehaviour {

    public GameObject Goal;

    public float Speed;

    public float Target;


    void Start()
    {

    }

    void Update()
    {
        Vector3 Direction = Goal.transform.position - transform.position;
        transform.forward = Direction.normalized;
        float Speed2 = Speed - Vector3.Distance(transform.position, Goal.transform.position);
        if (Speed2 <= 0.1f)
        {
            Speed2 = 0.1f;
        }
        transform.position += Direction * (Time.deltaTime * Speed2);

    }
}

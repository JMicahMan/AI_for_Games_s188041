using UnityEngine;

public class WanderBehaviour : MonoBehaviour {
    public float focusTime = 2.0f;
    public float Speed;
	void Update ()
    {
        var point = Random.insideUnitSphere;


        focusTime -= Time.deltaTime;
        Vector3 dir = point - transform.position;

        if (focusTime < 0)
        {
            transform.forward = dir;
            focusTime = 2.0f;
        }
        transform.position += transform.forward * (Time.deltaTime * Speed);


    }
}

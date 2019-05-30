using UnityEngine;

public class FleeBehaviour : MonoBehaviour {


    public GameObject Goal;

    public float Speed;


    void Update()
    {
        Vector3 Direction = Goal.transform.position + transform.position;
        transform.forward = Direction.normalized;
        transform.position += transform.forward * (Time.deltaTime * Speed);

    }
}

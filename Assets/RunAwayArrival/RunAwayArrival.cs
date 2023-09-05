using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAwayArrival : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    [SerializeField] public Transform target;
    [SerializeField] private float max_speed;
    [SerializeField] private float slowingDownRatio;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //Steering
        Vector3 desired_velocity = (transform.position - target.position);

        float distance = desired_velocity.magnitude;



        if (distance > slowingDownRatio)
        {
            desired_velocity = desired_velocity.normalized * max_speed * (slowingDownRatio / distance);
            if (distance > slowingDownRatio * 6)
            {
                desired_velocity = Vector3.zero;
            }
            Debug.Log("Fuera");
        }
        else
        {
            Debug.Log("Dentro");
            desired_velocity = desired_velocity.normalized * max_speed;
        }

        Vector3 steering = desired_velocity - velocity;

        velocity = Vector3.ClampMagnitude(velocity + steering, max_speed);


        transform.position += velocity * Time.deltaTime;
    }
}

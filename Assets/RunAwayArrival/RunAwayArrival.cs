using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAwayArrival : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float max_speed;
    [SerializeField]
    private Vector3 Velocity;
    [SerializeField]
    private float slowingRadius;

    void Update()
    {
        Vector3 position = transform.position;
        Vector3 flee_desired_velocity = (position - target.position).normalized * max_speed;
        Vector3 seek_desired_velocity = flee_desired_velocity - Velocity;
        Velocity = Vector2.ClampMagnitude(Velocity + seek_desired_velocity, max_speed);

        var distance = Vector3.Distance(transform.position, target.position);
        Debug.Log(distance);
        if (distance >= slowingRadius)
        {
            flee_desired_velocity = (flee_desired_velocity).normalized * max_speed * (distance / slowingRadius);
        }
        else
        {
            transform.position += Velocity * Time.deltaTime;
        }
    }
}

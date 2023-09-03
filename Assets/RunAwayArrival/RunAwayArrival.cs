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
        Vector3 fleeDesiredVelocity = (position - target.position).normalized * max_speed;
        Vector3 seekDesiredVelocity = fleeDesiredVelocity - Velocity;
        Velocity = Vector2.ClampMagnitude(Velocity + seekDesiredVelocity, max_speed);

        var distance = Vector3.Distance(transform.position, target.position);
        if (distance <= slowingRadius)
        {
            fleeDesiredVelocity = (fleeDesiredVelocity).normalized * (max_speed * (distance / slowingRadius));
            transform.position += fleeDesiredVelocity * Time.deltaTime;
        }
        if (distance > slowingRadius)
        {
            transform.position += Velocity * Time.deltaTime;
        }
    }
}

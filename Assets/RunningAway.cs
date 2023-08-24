using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningAway : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float max_velocity;
    [SerializeField]
    private Vector3 Velocity;

    private void Update()
    {
        Vector3 position = transform.position;
        Vector3 flee_desired_velocity = (position - target.position).normalized * max_velocity;
        Vector3 seek_desired_velocity = flee_desired_velocity - Velocity;
        Velocity = Vector2.ClampMagnitude(Velocity + seek_desired_velocity, max_velocity);
        transform.position += Velocity * Time.deltaTime;
    }
}

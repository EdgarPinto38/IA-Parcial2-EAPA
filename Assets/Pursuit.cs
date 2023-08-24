using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : MonoBehaviour
{
    [SerializeField]
    private float T;
    [SerializeField]
    private Movement target;
    [SerializeField]
    private Vector3 futureposition;
    [SerializeField]
    private float max_speed;

    private void Update()
    {
        var velocity = transform.position / Time.deltaTime;

        Vector3 position = transform.position;
        Vector3 desired_velocity = (target.transform.position - position).normalized * max_speed;
        Vector3 steering = desired_velocity - velocity;
        velocity = Vector2.ClampMagnitude(velocity + steering, max_speed);
        transform.position += velocity * Time.deltaTime;

        futureposition = transform.position + velocity * T;
    }
}

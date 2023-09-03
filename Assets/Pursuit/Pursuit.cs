using System;
using UnityEngine;

public class Pursuit : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    [SerializeField] private Movement target;
    [SerializeField] private float maxSpeed;
    [SerializeField] private int T;

    private void Start()
    {
        target.Tposition *= T;
    }

    private void Update()
    {
        target.Tposition.z = 0;
        var desiredVelocity = (target.Tposition - transform.position).normalized * maxSpeed;
        var steering = desiredVelocity - velocity;
        velocity = Vector3.ClampMagnitude(velocity + steering, maxSpeed);
        transform.position += velocity * Time.deltaTime;
    }
}

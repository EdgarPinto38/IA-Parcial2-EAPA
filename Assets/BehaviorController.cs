using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorController : MonoBehaviour
{

    public List<SteeringBehavior> behaviour = new List<SteeringBehavior>();
    public Rigidbody rigibody;
    public Vector3 velocity;
    public Vector3 totalForce = Vector3.zero;

    void Start()
    {

    }

    void FixedUpdate()
    {
        //inicializamos la fuerza en 0
        totalForce = Vector3.zero;

        //sacar el vector de la fuerza total
        foreach (SteeringBehavior behaviour in behaviours)
        {
            totalForce += behaviour.GetForce();
        }

        //movimiento
        velocity += totalForce;
        transform.position += velocity * Time.deltaTime();
    }

}

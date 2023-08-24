using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
       [SerializeField]
       private Transform target;
       [SerializeField]
       private float max_speed;
       [SerializeField]
       private Vector3 Velocity;

   void Update()
   {
       Vector3 position = transform.position;
       Vector3 desired_velocity = (target.position - position).normalized * max_speed;
       Vector3 steering = desired_velocity - Velocity;
       Velocity = Vector2.ClampMagnitude(Velocity + steering, max_speed);
       transform.position += Velocity * Time.deltaTime;
   }
}

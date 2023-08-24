using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    /*
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float max_speed;
    [SerializeField]
    private Vector3 Velocity;

    private void Update()
    {

    }

    void Seek()
    {
        Vector3 position = transform.position;
        Vector3 desired_velocity = (target.position - position).normalized * max_speed;
        Vector3 steering = desired_velocity - Velocity;
        Velocity = Vector2.ClampMagnitude(Velocity + steering, max_speed);
        transform.position += Velocity * Time.deltaTime;
    }

    private IEnumerator ChangeTarget()
    {

        yield return new WaitForSeconds(3f);
    }
    */

}

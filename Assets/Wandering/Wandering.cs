using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Wandering : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    Vector3 _velocity;
    Vector3 _previous;
    [SerializeField] private float circleDistance;
    [SerializeField] private float radio;

    private float _angle = 20;
    [SerializeField] private Vector2 angleRange;
    [SerializeField] private float angleTimer;

    private Vector3 _randomTarget;
    [SerializeField] private float targetTimer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("RandomAngle");
        StartCoroutine("RandomTarget");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredVelocity = (_randomTarget - transform.position).normalized * maxSpeed;

        Vector3 steering = desiredVelocity - _velocity;
        steering += WanderForce();

        _velocity = Vector3.ClampMagnitude(_velocity + steering, maxSpeed);

        transform.position += _velocity * Time.deltaTime;

        
        /* velocity = ((transform.position - previous)) / Time.deltaTime;
         previous = transform.position;*/
    }

     Vector3 WanderForce()
    {
        Vector3 circleCenter = _velocity.normalized * circleDistance;
        Vector3 displacement = Vector3.forward * radio;
        Quaternion rotation = Quaternion.AngleAxis(_angle, Vector3.up);
        displacement = rotation * displacement;
        DrawVectors(circleCenter, displacement);
        return circleCenter + displacement;
    }

    IEnumerator RandomAngle()
    {
        while (true)
        {
            _angle = Random.Range(angleRange.x, angleRange.y);
            yield return new WaitForSeconds(angleTimer);
        }
    }


    IEnumerator RandomTarget()
    {
        while (true)
        {
            _randomTarget = new Vector3(Random.Range(-20f, 20f), Random.Range(-10f, 10f),0 );
            yield return new WaitForSeconds(targetTimer);
        }
    }
    private void DrawVectors(Vector3 center, Vector3 displacement)
    {
        Debug.DrawLine(transform.position, transform.position + center, Color.green);
        Debug.DrawLine(transform.position + center, transform.position + center + displacement, Color.red);
        Debug.DrawLine(transform.position, transform.position + center + displacement, Color.blue);
    }
}
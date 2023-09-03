using UnityEngine;

public class Evade : MonoBehaviour
{
    [SerializeField] private Vector3 Velocity;
    [SerializeField] private Movement target;
    [SerializeField] private float maxSpeed;
    [SerializeField] private int T;

    private void Start()
    {
        target.transform.position *= T;
    }

    private void Update()
    {
        target.Tposition.z = 0;
        var fleeDesiredVelocity = (transform.position - target.Tposition).normalized * maxSpeed;
        var seekDesiredVelocity = fleeDesiredVelocity - Velocity;
        Velocity = Vector2.ClampMagnitude(Velocity + seekDesiredVelocity, maxSpeed);
        transform.position += Velocity * Time.deltaTime;
    }
}

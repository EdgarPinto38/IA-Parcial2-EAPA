using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : SteeringBehavior
{
    public bool arrival;
    public float slowingRadius;

    public override Vector3 GetForce()
    {
        return Vector3.zero;
    }
}

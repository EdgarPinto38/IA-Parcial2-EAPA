using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        var Vertical = Input.GetAxis("Vertical");
        var Horizontal = Input.GetAxis("Horizontal");

        transform.position = ((Horizontal, Vertical, 0) * speed * Time.deltaTime);
        
    }
}

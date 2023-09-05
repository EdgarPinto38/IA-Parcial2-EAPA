using UnityEngine;

public class Limits : MonoBehaviour
{
    void Update()
    {
        float xPos = Mathf.Clamp(transform.position.x, -11, 11);
        float yPos = Mathf.Clamp(transform.position.y, -5, 5);

        transform.position = new Vector3(xPos, yPos, 0);
    }

}

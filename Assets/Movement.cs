using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 _previous;
    public Vector3 Tposition;
    public Vector3 velocity;
    
    private void Update()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 0;
        var worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        
        var mouseInputX= Input.GetAxisRaw("Horizontal");
        var mouseInputY = Input.GetAxisRaw("Vertical");
        
        transform.position = new Vector3(worldPosition.x, worldPosition.y, 0);
        
        velocity = ((transform.position-_previous)) / Time.deltaTime;
        _previous = transform.position;

        Tposition = transform.position + velocity;
    }
}

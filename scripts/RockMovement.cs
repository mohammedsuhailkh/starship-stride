using UnityEngine;

public class RockMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;   
    public float moveDistance = 1.0f; 

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
       
        float newPositionY = initialPosition.y + Mathf.Sin(Time.time * moveSpeed) * moveDistance;

        
        transform.position = new Vector3(transform.position.x, newPositionY, transform.position.z);
    }
}

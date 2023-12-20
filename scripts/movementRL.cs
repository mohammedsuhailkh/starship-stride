using UnityEngine;

public class movementRL : MonoBehaviour
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
       
        float newPositionX = initialPosition.y + Mathf.Sin(Time.time * moveSpeed) * moveDistance;

        
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}

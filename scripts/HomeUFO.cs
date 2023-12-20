using UnityEngine;

public class HomeUFO : MonoBehaviour
{
    public float moveSpeed = 1.0f;   
    public float moveDistance = 1.0f; 

    private Vector3 initialPosition;
    private AudioSource audioSource;

    void Start()
    {
        initialPosition = transform.position;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
  
    }

    void Update()
    {
        
       
        float newPositionY = initialPosition.y + Mathf.Sin(Time.time * moveSpeed) * moveDistance;

        
        transform.position = new Vector3(transform.position.x, newPositionY, transform.position.z);
    }
}

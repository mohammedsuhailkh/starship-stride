using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool moveLeft = true;
    Animator anim;
    int count = 1;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("WalkForward", true);
    }

    void Update()
    {
        // Move left or right based on the current direction
        if (moveLeft)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            transform.localScale = new Vector3(3.4925f, 3.4925f, 3.4925f);
        }
        else
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            transform.localScale = new Vector3(3.4925f, 3.4925f, -3.4925f);
        }

        if (transform.position.x == 3.9f)
        {
            anim.SetBool("WalkForward", false);
           
        }else{
            
            anim.SetBool("WalkForward", true);
        }
    }

    // Detect collisions with obstacles
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacles"))
        {
            moveLeft = false;
             anim.SetTrigger("Attack5");
            Debug.Log("collided");
           
        }
        if (collision.gameObject.CompareTag("Respawn"))
        {
            moveLeft = true;
             anim.SetTrigger("Attack5");
            Debug.Log("collided");
           
        }
    }
}

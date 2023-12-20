using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] float flyThrust = 100f;
    [SerializeField] float rotateForce = 1f;
    [SerializeField] AudioClip getEngine;
    [SerializeField] ParticleSystem jetThrust;
    private bool isThrusting = false;
    private bool rotateLeft = false;
    private bool rotateRight = false;
    public AudioSource sound;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        processThrust();
        processRotation();
        rotate();
    }

    public void processThrust()
    {
        if (Input.GetKey(KeyCode.Space) || isThrusting)
        {
            rb.AddRelativeForce(Vector3.up * flyThrust * Time.deltaTime);
            if (!sound.isPlaying)
            {
                sound.PlayOneShot(getEngine);
                jetThrust.Play();
            }
        }
        else
        {
            sound.Stop();
            jetThrust.Stop();
        }
    }

    void processRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotationThrust(rotateForce);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationThrust(-rotateForce);
        }
    }

    void rotationThrust(float rotate)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotate * Time.deltaTime);
        rb.freezeRotation = false;
    }


        public void thrustStart()
    {
        isThrusting = true;
    }

    public void thrustStop()
    {
        isThrusting = false;
    }
    public void rotateLeftStart()
    {
        rotateLeft = true;
    }

    public void rotateLeftStop()
    {
        rotateLeft = false;
    }

    public void rotateRightStart()
    {
        rotateRight = true;
    }

    public void rotateRightStop()
    {
        rotateRight = false;
    }

    public void rotate()
    {
        if (rotateLeft)
        {
            rotationThrust(rotateForce);
        }
        else if (rotateRight)
        {
            rotationThrust(-rotateForce);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    AudioSource audioSource;
    float horizontalSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   

    }

    void FixedUpdate(){
        float h = horizontalSpeed * Input.GetAxis("Mouse X");

        transform.Rotate(0, h, 0);

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 dirVector = new Vector3 (horizontal,Input.GetAxis("Jump"),vertical).normalized;
        GetComponent<Rigidbody>().MovePosition(transform.position + (dirVector * speed) * Time.deltaTime);
    }

    // Detect collision with another object
    void OnCollisionEnter(Collision other){

        foreach (ContactPoint contact in other.contacts){
            Debug.Log(contact.point);
        }
        if(other.relativeVelocity.magnitude > 2){
            audioSource.Play();
        }

    }

    void OnTriggerEnter(Collider other){
        
    }
}

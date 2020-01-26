using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   
        float jumpTranslation = Input.GetAxis("Jump");
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0,0,translation);
        transform.Rotate(0,rotation,0);
        transform.Translate(0,jumpTranslation,0);
    }

    // Detect collision with another object
    void OnCollisionEnter(Collision other){
        audioSource.Play();
    }

    void OnTriggerEnter(Collider other){
        Debug.Log("An event has been triggered!");
    }
}

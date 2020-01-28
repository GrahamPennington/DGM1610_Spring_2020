using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public float horizontalSpeed = 2.0f;
    char got;

    // Start is called before the first frame update
    void Start()
    {

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

        
        if(other.gameObject.CompareTag("Obstacle")){

            Debug.Log("Colliding with an obstacle");
            foreach(ContactPoint contacts in other.contacts){
                Debug.Log(contacts.point);
            }
        }
        else if (other.gameObject.CompareTag("Floor")){
            Debug.Log("Colliding with floor");
        }
        else{
            Debug.Log("Not colliding");
        }
    } 

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("PowerUp")){
            Destroy(other.gameObject);
            Debug.Log("You got the power up");
        }
    }
}

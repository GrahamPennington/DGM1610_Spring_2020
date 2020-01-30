using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float rotationSpeed;
    public float jumpInput;
    public float jumpSpeed;

    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetAxis("Jump");
    }

    void FixedUpdate(){
        Vector3 dirVector = new Vector3 (0,(jumpInput * jumpSpeed),(verticalInput * speed));
        //transform.Translate(dirVector * Time.deltaTime);
        Vector3 rotVector = new Vector3 (0,horizontalInput,0).normalized;
        //transform.Rotate(rotVector * rotationSpeed * Time.deltaTime);
        m_Rigidbody = GetComponent<Rigidbody>();
        // Vector3 dirVector = new Vector3 (0,0,verticalInput).normalized;

        // Vector3 m_EulerAngleVelocity = new Vector3(0, horizontalInput, 0);
        // Quaternion rotVector = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
        m_Rigidbody.MovePosition(transform.position + dirVector * Time.deltaTime);
        Quaternion deltaRotation = Quaternion.Euler(rotVector * rotationSpeed * Time.deltaTime);
        m_Rigidbody.MoveRotation(transform.rotation * deltaRotation);
        
        //transform.Rotate(0,(horizontal * speed),0);
    }

    // Detect collision with another object
    // void OnCollisionEnter(Collision other){

        
    //     if(other.gameObject.CompareTag("Obstacle")){

    //         Debug.Log("Colliding with an obstacle");
    //         foreach(ContactPoint contacts in other.contacts){
    //             Debug.Log(contacts.point);
    //         }
    //     }
    //     else if (other.gameObject.CompareTag("Floor")){
    //         Debug.Log("Colliding with floor");
    //     }
    //     else{
    //         Debug.Log("Not colliding");
    //     }
    // } 

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("PowerUp")){
            Destroy(other.gameObject);
            Debug.Log("You got the power up");
        }
    }
}

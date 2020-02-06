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
        
        transform.Translate(0,jumpInput * jumpSpeed * Time.deltaTime,(verticalInput * speed * Time.deltaTime));
        transform.Rotate(0,(horizontalInput * rotationSpeed * Time.deltaTime),0);
    }

}

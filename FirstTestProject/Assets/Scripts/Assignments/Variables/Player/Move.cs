using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 12f;
    public float inputZ;
    public float inputX;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float mouseSensitivity = 100f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public Rigidbody _body;
    public Transform head;

    private Vector3 velocity;
    private bool isGrounded;
    private float mouseX;
    private float mouseY;
    private float xRotation = 0f;


    void Start() 
    {
        _body = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {   
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0){

            velocity.y = -2f;
        }

        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        Vector3 move = (transform.right * inputX + transform.forward * inputZ).normalized;
        _body.MovePosition(transform.position + move * speed * Time.fixedDeltaTime);

        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.fixedDeltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.fixedDeltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 75f);

        head.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        _body.MoveRotation(_body.rotation * Quaternion.Euler(new Vector3(0, mouseX, 0)));

        // if(Input.GetKeyDown(KeyCode.LeftControl)){
        //     head.transform.position -= new Vector3 (0,0.2f,0);
        // }

        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            _body.AddForce(Vector2.up * velocity * 20f);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float rotationSpeed;


    public GameObject projectilePreFab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if(Input.GetMouseButtonDown(0)){
            Instantiate(projectilePreFab, transform.position, projectilePreFab.transform.rotation);
        }
    }

    void FixedUpdate(){
        
        transform.Translate(0,0,(verticalInput * speed * Time.deltaTime));
        transform.Rotate(0,(horizontalInput * rotationSpeed * Time.deltaTime),0);
    }

}

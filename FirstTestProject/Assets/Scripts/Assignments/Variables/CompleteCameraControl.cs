using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCameraControl : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    float horizontalSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        
    }

    void FixedUpdate(){
        float h = horizontalSpeed * Input.GetAxis("CameraRotation");
        transform.Rotate(0,0,h);
    }

    void LateUpdate(){
        transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

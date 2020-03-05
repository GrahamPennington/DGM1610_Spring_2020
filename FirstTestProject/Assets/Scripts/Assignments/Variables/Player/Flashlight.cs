using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    private Light light;

    void Start(){
        light = GetComponent<Light>();
        light.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (light.enabled == true)
            {  
                light.enabled = false;
                
            }
            else if (light.enabled == false)
            {  
                light.enabled = true;
            
            }
        }
 
    }

}

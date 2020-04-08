using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    private Light flashlight;

    void Start(){
        flashlight = GetComponent<Light>();
        flashlight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashlight.enabled == true)
            {  
                flashlight.enabled = false;
                
            }
            else if (flashlight.enabled == false)
            {  
                flashlight.enabled = true;
            
            }
        }
 
    }

}

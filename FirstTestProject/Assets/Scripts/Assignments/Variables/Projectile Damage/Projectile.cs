using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectilePreFab;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2")){
            Instantiate(projectilePreFab, transform.position, transform.rotation);
        }
    }
}

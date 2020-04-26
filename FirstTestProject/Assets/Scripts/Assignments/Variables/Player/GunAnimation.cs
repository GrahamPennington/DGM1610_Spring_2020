using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimation : MonoBehaviour
{

    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isFiring", false);
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("isFiring", true);
            anim.Play("Recoil");
        }
    }
}

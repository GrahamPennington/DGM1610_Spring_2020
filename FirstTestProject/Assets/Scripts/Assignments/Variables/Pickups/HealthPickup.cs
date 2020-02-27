using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{

    public int healthAmt = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other){
        
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("You gain " + healthAmt + " health");
            Destroy(gameObject);
        }
    }
}

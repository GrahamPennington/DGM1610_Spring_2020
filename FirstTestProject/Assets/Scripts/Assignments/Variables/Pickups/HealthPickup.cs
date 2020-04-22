using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{

    public int healthAmt = 5;
    

    void OnTriggerEnter(Collider other){
        
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("You gain " + healthAmt + " health");
            var health = other.GetComponent<Health>();
            health.TakeDamage((-healthAmt));
            Destroy(gameObject);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuff : Pickup
{
    public int health;

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
            ScoreManager.RemovePoints(health);
            Destroy(gameObject);
        }
        
    }
}

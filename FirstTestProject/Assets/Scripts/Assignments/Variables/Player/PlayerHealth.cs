using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{

    public static int health = 20;

    [SerializeField] private Text healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        health = currentHealth;
        healthText.text = string.Format("Health {0}/{1}", currentHealth.ToString(), maxHealth.ToString());
    }
}

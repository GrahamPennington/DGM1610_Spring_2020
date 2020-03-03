using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth = 5;
    public Transform spawnPoint;
    public int points = 10;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        if(currentHealth <= 0){

            currentHealth = 0;
            Debug.Log("Enemy is dead");
            Destroy(gameObject);

        }
        
    }
}

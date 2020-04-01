using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
        public int maxHealth;
        public int currentHealth;

        private void Start()
        {
                currentHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
                currentHealth -= damage;

                if (currentHealth <= 0)
                {
                        currentHealth = 0;
                        Debug.Log(gameObject.tag + " has died.");

                        if (gameObject.tag == "Enemy")
                        {
                                Destroy(gameObject);
                        }
                        else if (gameObject.tag == "Player")
                        {
                                Debug.Log("Please try better.");
                        }
                }
        }
}
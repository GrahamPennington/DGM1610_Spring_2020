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
                currentHealh -= damage;

                if (currentHealh <= 0)
                {
                        currentHealh = 0;
                        Debug.Log(gameObject.tag + " has died.");

                        if (gameObject.tag == "Enemy")
                        {
                                Destroy(gameObject);
                        }
                        else if (gameObject.tag == "Player")
                        {
                                currentHealh = maxHealth;
                                Debug.Log("Please try better.");
                                Debug.Log("Resetting player's health to " + currentHealh);
                        }
                }
        }
}
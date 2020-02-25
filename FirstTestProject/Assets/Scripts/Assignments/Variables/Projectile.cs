using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectilePreFab;
    
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Instantiate(projectilePreFab, transform.position, transform.rotation);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit Enemy");
            Debug.Log(other.gameObject.GetComponent<EnemyMove>().health);
            other.gameObject.GetComponent<EnemyMove>().health -= 10;
        }
    }
}

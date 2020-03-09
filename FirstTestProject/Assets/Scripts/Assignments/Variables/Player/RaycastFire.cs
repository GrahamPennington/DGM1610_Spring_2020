using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFire : MonoBehaviour
{
    public GameObject explosion;

    public int damage = 2;

    // Update is called once per frame
    void Update()
    {

        float hitForce = 200f;
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Input.GetButtonDown("Fire1"))
            if (Physics.Raycast(ray, out hit, 100))
            {
                print("Hit something!");
                Debug.DrawLine(ray.origin, hit.point);
                
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(ray.direction * hitForce);
                    GameObject explPoint = Instantiate(explosion, hit.point, Quaternion.identity);
                    explPoint.GetComponent<ParticleSystem>().Play();
                    Destroy(explPoint, 3);
                }

                if (hit.collider.tag == "Enemy")
                {
                    var health = hit.collider.GetComponent<EnemyHealth>();

                    if (health != null){
                        health.TakeDamage(damage);
                        Debug.Log("Ouch, you hit me!");
                    }
                }
            }

    }
}

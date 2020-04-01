using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFire : MonoBehaviour
{
    public GameObject explosion;
    public GameObject flash;

    public int damage = 2;

    private void Start()
    {
        flash.SetActive(false);
    }
    
    private void Update()
    {
        float hitForce = 200f;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetButtonDown("Fire1") && Time.timeScale != 0)
        {
            flash.SetActive(true);
            StartCoroutine(MuzzleFlashTimer());
            if (Physics.Raycast(ray, out hit, 100f))
            {
                print("Hit something!");
                Debug.DrawLine(ray.origin, hit.point);

                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(ray.direction * hitForce);
                    GameObject explPoint = Instantiate(explosion, hit.point, Quaternion.identity);
                    explPoint.GetComponent<ParticleSystem>().Play();
                    Destroy(explPoint, 3);
                    if (hit.collider.tag == "Enemy")
                    {
                        var health = hit.collider.GetComponent<Health>();

                        if (health != null)
                        {
                            health.TakeDamage(damage);
                            Debug.Log("Ouch, you hit me!");
                        }
                    }
                }

            }
        }
    }

    private IEnumerator MuzzleFlashTimer()
    {
        yield return new WaitForSeconds(0.03f);
        flash.SetActive(false);
    }
}

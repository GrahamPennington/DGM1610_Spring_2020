using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public int damage = 1;
    public GameObject player;

    private bool canFire;
    private float rateOfFire = 3f;
    

    private void Start()
    {
        player = GameObject.Find("Player");
        canFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = (player.transform.position + new Vector3(Random.Range(-2f, 2f),0,0)) - transform.position;
        
        Ray ray = new Ray(transform.position, targetDir);
        RaycastHit hit;

        float angle = EnemyMove.angle;

        if (Physics.Raycast(ray, out hit, 100f) && canFire && angle < 75f)
        {
            StartCoroutine(Fire(ray, hit));
        }
    }

    private IEnumerator Fire(Ray ray, RaycastHit hit)
    {
        canFire = false;
        Debug.DrawLine(ray.origin, hit.point);
        if (hit.collider.tag == "Player")
        {
            var health = hit.collider.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(damage);
                Debug.Log("Ouch, you hit me!");
            }
        }
        yield return new WaitForSeconds(rateOfFire);
        canFire = true;
    }
}

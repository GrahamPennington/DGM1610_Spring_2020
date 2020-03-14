using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject Explosion;

    public int damage = 1;
    public int time = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision other){
        
        Explode();
        
        if(other.gameObject.CompareTag("Enemy")){
            var hit = other.gameObject;
            var health = hit.GetComponent<Health>();

            if (health != null && hit.CompareTag("Enemy")){
                health.TakeDamage(damage);
                Debug.Log("Ouch, you hit me!");
                Destroy(gameObject);
            }
        }
    }

    IEnumerator DestroyBullet(){
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    void Explode(){
        GameObject hit = Instantiate(Explosion, transform.position, Quaternion.identity);
        hit.GetComponent<ParticleSystem>().Play();
        Destroy(hit, 3);
    }
}

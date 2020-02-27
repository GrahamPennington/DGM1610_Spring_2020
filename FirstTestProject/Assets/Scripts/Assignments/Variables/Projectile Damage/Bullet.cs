using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public int time = 3;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision other){
        var hit = other.gameObject;
        var health = hit.GetComponent<EnemyHealth>();

        if (health != null){
            health.TakeDamage(damage);
            Debug.Log("Ouch, you hit me!");
            Destroy(gameObject);
        }
    }

    // IEnumerator DestroyBullet(){
    //     yield return new WaitForSeconds(time);
    //     DestroyBullet(gameObject);
    // }
}

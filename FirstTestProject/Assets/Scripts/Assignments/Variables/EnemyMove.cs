using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public GameObject player;
    private Rigidbody enemyRb;
    public float moveSpeed;
    public int health = 50;

    private enum State {
        Waiting,
        Chasing,
    }

    private State state;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRb = GetComponent<Rigidbody>();
        state = State.Waiting;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        switch(state) {
            default:
            case State.Waiting:
                if(distance < 15f){
                    state = State.Chasing;
                }
                break;
            case State.Chasing:
                transform.LookAt(player.transform);
                enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);
                if(distance > 23f){
                    state = State.Waiting;
                }
                break;
        }
        
    }
}

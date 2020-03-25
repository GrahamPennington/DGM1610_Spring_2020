using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public GameObject player;
    private Rigidbody enemyRb;
    public float moveSpeed;

    public static float angle;

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
    
    
    void FixedUpdate()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        Vector3 targetDir = player.transform.position - transform.position;
        angle = Vector3.Angle(targetDir, transform.forward);
        
        switch(state) {
            default:
            case State.Waiting:
                if(angle < 75f && distance < 10f){
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

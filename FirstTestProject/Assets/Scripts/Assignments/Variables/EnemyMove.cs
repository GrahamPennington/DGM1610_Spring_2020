using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Transform target;
    public float moveSpeed;
    public int health = 50;
    public int damage;

    private enum State {
        Waiting,
        Chasing,
    }

    private State state;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
        state = State.Waiting;
    }

    // Update is called once per frame
    void Update()
    {
         float distance = Vector3.Distance(target.position, transform.position);
        switch(state) {
            default:
            case State.Waiting:
                if(distance < 10f){
                    state = State.Chasing;
                }
                break;
            case State.Chasing:
                transform.LookAt(target);
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                if(distance > 22f){
                    state = State.Waiting;
                }
                break;
        }
        
    }
}

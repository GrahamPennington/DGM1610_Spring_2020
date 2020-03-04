using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Light light;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        light.enabled = false;

        player = GameObject.Find("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
    }

    void OnTriggerEnter(Collider other) {

       light.enabled = true;
        
    }
}

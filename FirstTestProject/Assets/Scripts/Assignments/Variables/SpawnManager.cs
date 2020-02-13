using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPreFabs;
    public int enemyIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.E)){
            Instantiate(enemyPreFabs[enemyIndex], new Vector3(0,0,0), enemyPreFabs[enemyIndex].transform.rotation);
        }
        
    }
}

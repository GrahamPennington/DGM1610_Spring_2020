using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSpawn : MonoBehaviour
{
    public GameObject[] spawnPoints;
    private int spawnIndex;
    public int numberOfEnemies;
    public GameObject[] enemyPreFabs;
    private int enemyIndex;
    

    private void Start()
    {
        numberOfEnemies = 5;
        HandleEnemySpawn();
    }

    private void HandleEnemySpawn()
    {

        for (int i = 0; i < numberOfEnemies; i++)
        {
            enemyIndex = Random.Range(0, enemyPreFabs.Length);
            spawnIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyPreFabs[enemyIndex], spawnPoints[spawnIndex].transform.position,
                enemyPreFabs[enemyIndex].transform.rotation);
        }
    }

}
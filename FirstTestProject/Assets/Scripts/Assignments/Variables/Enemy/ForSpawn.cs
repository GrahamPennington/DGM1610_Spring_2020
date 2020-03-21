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
        numberOfEnemies = 2;
        HandleEnemySpawn();
    }

    private void HandleEnemySpawn()
    {
        enemyIndex = Random.Range(0, enemyPreFabs.Length);
        spawnIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < numberOfEnemies; i++)
        {
            Instantiate(enemyPreFabs[enemyIndex], spawnPoints[spawnIndex].transform.position,
                enemyPreFabs[enemyIndex].transform.rotation);
        }
    }

}
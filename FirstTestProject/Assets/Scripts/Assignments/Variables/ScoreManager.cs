using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 20;
        Debug.Log("Health: " + score);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public static void AddPoints(int health){
        score += health;
        Debug.Log("Health: " + score);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour
{

    public Text winLabel;
    public Text timerLabel;

    private float time;

    private bool alive;
    
    private void Start()
    {
        StartCoroutine(Timer());
        time = 60f;
        alive = true;
    }

    private void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;

            int minutes = (int) time / 60;
            int seconds = (int) time % 60;
            timerLabel.text = "Time: " + minutes.ToString() + ":" + seconds.ToString("00");
        }

        if (PlayerHealth.health <= 0)
        {
            alive = false;
            WinOrLose();
            Time.timeScale = 0;
        }
    }


    private void WinOrLose()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length != 0 || !alive)
        {
            winLabel.text = "You Lose!";
        }
        else
        {
            winLabel.text = "You Win!";
        }
        
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(60);

        WinOrLose();
    }
}

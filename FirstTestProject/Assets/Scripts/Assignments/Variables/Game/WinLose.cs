using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour
{

    public Text winLabel;
    public Text timerLabel;

    private float time;
    
    private void Start()
    {
        StartCoroutine(Timer());
        time = 60f;
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

    }
    

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(60);

        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            winLabel.text = "You Win!";
        }
        else
        {
            winLabel.text = "You Lose!";
        }
    }
}

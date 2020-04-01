using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitScreen : MonoBehaviour
{
    public Button retryButton;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        Button btn = retryButton.GetComponent<Button>();
        btn.onClick.AddListener(Retry);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            panel.SetActive(true);
           
        }
    }

    private void Retry()
    {
        SceneManager.LoadScene("Level0");
        Debug.Log("Restarting game...");
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }
}

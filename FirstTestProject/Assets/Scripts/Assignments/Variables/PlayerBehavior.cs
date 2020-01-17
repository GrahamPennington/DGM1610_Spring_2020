using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public float xPos;
    public float yPos;
    public float zPos;

    // Start is called before the first frame update
    void Start()
    {
        xPos = 0;
        yPos = 0;
        zPos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            zPos = 1;
            Debug.Log("space was pressed");
        }
    }

}

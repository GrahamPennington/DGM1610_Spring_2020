using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var1 : MonoBehaviour
{
    public float amount;
    public float money;
    public float cost;
    public string name;
        

    // Start is called before the first frame update
    void Start()
    {
        Cookies(amount, money, cost);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            SetName();
        }
    }

    void Cookies(float amount, float money, float cost)
    {
        float total;
        total = money - (cost * amount);
        print(total);
    }
    void SetName()
    {
        name = "Bob";
        Debug.Log("Huh, my name is " + name + " too!");
    }
}

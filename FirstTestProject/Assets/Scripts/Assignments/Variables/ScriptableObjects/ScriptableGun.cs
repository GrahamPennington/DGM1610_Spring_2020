using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Gun", menuName="Scriptable Object\Gun Object")]

public class ScriptableGun : ScriptableObject
{
    public string guntName;

    public string description;

    public int damage;

    public float rateOfFire;

    public GameObject model;

    public Color color;
    
}
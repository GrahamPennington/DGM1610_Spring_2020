using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptablePistol : MonoBehaviour
{
    public ScriptableGun data;

    private GameObject model;

    public int pistolDamage;

    public float pistolRoF;

    private void Start()
    {
        model = data.model;
        pistolDamage = data.damage;
        pistolRoF = data.rateOfFire;

        var modelRend = model.GetComponent<Renderer>();
        modelRend.sharedMaterial.SetColor("_Color", data.color);

    }
    
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SciptablePistol : MonoBehaviour
{
    public ScriptableGun data;

    public static int pistolDamage;

    public float pistolRoF;

	[SerializeField] private GameObject model;

    private void Start()
    {
        model = data.model;
        pistolDamage = data.damage;
        pistolRoF = data.rateOfFire;

        var modelRend = model.GetComponent<Renderer>();
        modelRend.sharedMaterial.SetColor("_Color", data.color);

    }
    
}
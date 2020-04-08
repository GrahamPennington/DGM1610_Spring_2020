using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOTest : MonoBehaviour
{
    public SO data;

    public GameObject model;

    private void Start()
    {
        model = data.model;

        var modelRend = model.GetComponent<Renderer>();
        modelRend.sharedMaterial.SetColor("_Color", data.color);

        print(data.objectName);
        print(data.description);

    }
}

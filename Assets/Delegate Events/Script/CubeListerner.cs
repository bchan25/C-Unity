using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeListerner : MonoBehaviour
{
    private void Start()
    {
        EventExample.onClick += TurnRed;
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}

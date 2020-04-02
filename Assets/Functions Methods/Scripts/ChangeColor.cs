using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject cube;
    public Color newColor;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeObjectColor(cube, newColor);
        }
    }

    private void ChangeObjectColor(GameObject cube, Color color)
    {
        cube.GetComponent<Renderer>().material.SetColor("_Color", color);
    }
}

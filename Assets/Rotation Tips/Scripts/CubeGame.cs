using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGame : MonoBehaviour
{
    public GameObject cube;
    public int score = 0;

    Renderer cubeRenderer;

    private bool hasCalled = false;

    void Awake()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    private void Start()
    {
        cubeRenderer.material.SetColor("_Color", Color.red);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !hasCalled)
        {
            score += 10;
        }

        if(score == 50 && !hasCalled)
        {
            hasCalled = true;
            cubeRenderer.material.SetColor("_Color", Color.green);
            Invoke("ResetGame", 1.5f);
        }
    }

    void ResetGame()
    {
        score = 0;
        hasCalled = false;
        cubeRenderer.material.SetColor("_Color", Color.red);
    }
}

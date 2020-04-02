using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    public int selectedLevel;

    private int _easy = 0;
    private int _medium = 1;
    private int _hard = 2;

    private void Start()
    {
        selectedLevel = Random.Range(0, 3);
    }

    private void Update()
    {
        switch (selectedLevel)
        {
            case 0:
                Debug.Log("Easy level selected");
                break;
            case 1:
                Debug.Log("Medium level selected");
                break;
            case 2:
                Debug.Log("Hard level selected");
                break;
            default:
                Debug.Log("Not valid level");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            selectedLevel = Random.Range(0, 3);
        }
    }
}

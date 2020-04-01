using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfExample : MonoBehaviour
{
    public int easyDifficulty = 0;
    public int mediumDifficulty = 1;
    public int hardDifficulty = 2;
    public int currentDifficulty;

    void Start()
    {
        currentDifficulty = easyDifficulty;
    }

    private void Update()
    {
        if(currentDifficulty == easyDifficulty)
        {
            Debug.Log("Easy Difficulty");
        }
        else if(currentDifficulty == mediumDifficulty){
            Debug.Log("Medium Difficulty");
        }
        else if (currentDifficulty == hardDifficulty){
            Debug.Log("Hard Difficulty");
        }
        else
        {
            Debug.Log("Invalid Level Selected");
        }
    }

}

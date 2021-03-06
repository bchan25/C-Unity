﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeOne : MonoBehaviour
{
    [SerializeField]
    private int score = 0;

    private bool calledMessage = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && score != 50)
        {
            score += 10;
        }

        if(score == 50 && !calledMessage)
        {
            calledMessage = true;
            Debug.Log("You win");
            Debug.Log("Game Over");
            StartCoroutine(ResetGameRoutine());
        }
    }

    IEnumerator ResetGameRoutine()
    {
        yield return new WaitForSeconds(1.5f);
        score = 0;
        Debug.Log("Game Reset");
        calledMessage = false;
    }
}

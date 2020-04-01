using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    
    void Update()
    {
        // Pause
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            Debug.Log("Game Paused");
        }

        // Unpaused
        if(Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            Debug.Log("Game Unpaused");
        }

        // Slow Mo
        if(Input.GetKeyDown(KeyCode.S))
        {
            Time.timeScale = 0.5f;
            Debug.Log("Slow Mo");
            StartCoroutine(SpeedUpRoutine());
        }
    }

    IEnumerator SpeedUpRoutine()
    {
        Debug.Log("Speed Up Routine Stated");
        yield return new WaitForSeconds(2f);
        Time.timeScale = 1f;
        Debug.Log("Normal speed");
    }
}

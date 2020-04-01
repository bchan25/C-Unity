using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    
    void Update()
    {
        // User Input
        // If user press space button
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar pressed");
        }

        // if e key held down
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Holding");
        }

        // if f key lifted up
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F key lifted up");
        }
    }
}

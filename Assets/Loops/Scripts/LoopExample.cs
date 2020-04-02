using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExample : MonoBehaviour
{

    public string myName = "Ben";

    void Start()
    {
        // For Loop
        for (int i = 0; i < 10; i++)
        {
            // Only print even
            if(i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    
    void Update()
    {
        
    }
}

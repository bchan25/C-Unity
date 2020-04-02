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
            Debug.Log(myName);
        }
    }

    
    void Update()
    {
        
    }
}

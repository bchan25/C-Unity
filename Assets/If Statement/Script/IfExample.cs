using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfExample : MonoBehaviour
{
    public int myAge = 32;

    void Start()
    {
        // IF CONDITION
        // THEN RUN CODE

        // If myAge is greater than or equal to 17
        // then print out you can drive
        if(myAge >= 17)
        {
            Debug.Log("You can drive");
        }
        else
        {
            Debug.Log("You can't drive");
        }

    }

    
}

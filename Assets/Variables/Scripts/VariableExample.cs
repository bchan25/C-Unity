using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // <summary>
    // Variable = Label Box that holds data
    // public or private
    // data type (strings, bools, float, int)
    // name
    // value // OPTIONAL
    // </summary>

    public string myName;

    private int myAge = 32;
    private string myLocation = "Wales";
    public bool hasKey = false;

    void Start()
    {
        Debug.Log("Hello " + myName + ". You are " + myAge + " years old. Your from " + myLocation + ".");
	}
}

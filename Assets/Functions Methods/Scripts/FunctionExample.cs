using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    
    void Start()
    {
        // Called Method
        MyMethod();
        Add(4, 5);
        Debug.Log(Subtract(4, 2));
    }

    
    void Update()
    {
       
    }

    // Method
    private void MyMethod()
    {
        Debug.Log("MyMethod called");
    }

    private void Attack()
    {
        Debug.Log("Attack Code");
    }

    private void PowerUp()
    {
        Debug.Log("Powerup Code");
    }

    // Parameters
    private void Add(int a, int b)
    {
        Debug.Log(a + b);
    }

    // Return Type
    private int Subtract(int a, int b)
    {
        return a - b;
    }
}

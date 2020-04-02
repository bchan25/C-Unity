using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{

    // Array holds multiple values
    public string[] names;

    public string[] items = new string[5];

    public int[] ages = new int[] { 5, 4, 3, 2, 1 };

    private void Start()
    {
        // Access a array element
        Debug.Log(ages[3]); // prints 2

        // Loop array
        for (int i = 0; i < items.Length; i++)
        {
            Debug.Log("Items: " + items[i]);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 startPos;
    
    void Start()
    {
        // Change the position when game start
        transform.position = startPos;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    
    void Update()
    {
        // direction = destination - source
        Vector3 direction = target.position - transform.position;

        // Debug raw
        Debug.DrawRay(transform.position, direction, Color.blue);

        // Look this direction
        transform.rotation = Quaternion.LookRotation(direction);
    }
}

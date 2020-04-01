using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTransition : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    void Update()
    {
        // direction = destination - source
        Vector3 direction = target.position - transform.position;

        // Target rotation
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        // Interpolate value
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab;

  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ZERO Rotation 0, 0, 0
            // Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);

            // 35 degrees on Y
            Instantiate(cubePrefab, Vector3.zero, Quaternion.Euler(0, 35, 0));
        }
    }
}

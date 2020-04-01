using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 move = new Vector3(horizontalInput, transform.position.y, transform.position.z);

        // Move player with the translate
        transform.Translate(move * _speed * Time.deltaTime);
    }
}

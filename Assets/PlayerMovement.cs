using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float speed = 5;
public Rigidbody rb;
public float rbMovePosition;

float horizontalInput;

    private void FixeUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        // rbMovePosition(rb.position + forwardMove);
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    

}

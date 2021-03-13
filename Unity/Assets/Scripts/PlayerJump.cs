using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        rb.velocity = new Vector2(speed, 0);
    }
    void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(speed, jumpForce);
        }
    }
}

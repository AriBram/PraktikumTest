using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float forcePower = 5f;
    private Rigidbody2D rb;

    bool isMoveUp;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isMoveUp = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isMoveUp = true;
        }
        else
        {
            isMoveUp = false;
        }
    }

    private void FixedUpdate()
    {
        Vector2 moveVector = new Vector2(moveSpeed * Time.fixedDeltaTime, rb.velocity.y);

        rb.velocity = moveVector;
        MoveVertical();
    }

    private void MoveVertical()
    {
        if (isMoveUp)
        {
            rb.AddForce(Vector2.up * forcePower * Time.fixedDeltaTime);
        }
        else
        {
            rb.AddForce(Vector2.down * forcePower * Time.fixedDeltaTime);
        }

    }
}

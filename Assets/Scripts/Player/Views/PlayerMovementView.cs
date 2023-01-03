using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementView : PlayerElement
{
    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = transform.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash();
        }
    }

    private void Move()
    {
        app.movementController.OnPlayerMove();
    }

    private void Dash()
    {
        app.movementController.OnPlayerDash();
    }

    public void DoMove(Vector2 movement)
    {
        rb2D.velocity = movement;
    }
}

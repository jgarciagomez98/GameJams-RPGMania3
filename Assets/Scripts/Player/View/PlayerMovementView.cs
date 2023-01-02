using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementView : PlayerElement
{
    private Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = transform.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        Dash();
    }

    private void Move()
    {
        rb2D.velocity = playerApplication.playerMovementController.OnPlayerMove();
    }

    private void Dash()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            playerApplication.playerMovementController.OnPlayerDash();
        }
    }
}

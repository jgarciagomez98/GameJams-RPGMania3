using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : PlayerElement
{
    private const float DASH_DISTANCE = 0.2f;

    private float horizontalAxis;
    private float verticalAxis;
    private Vector2 velocity;

    private void Start()
    {
        app.model.CurrentSpeed = app.model.Speed;
    }

    private void Update()
    {
        setMovementAxis();
    }

    private void setMovementAxis()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
    }

    public void OnPlayerMove()
    {
        velocity = new Vector2(horizontalAxis * app.model.CurrentSpeed, verticalAxis * app.model.CurrentSpeed);
        app.movementView.DoMove(velocity);
    }

    public void OnPlayerDash()
    {
        if (canDash())
        {
            app.model.CurrentSpeed = app.model.DashSpeed;
            StartCoroutine(DashDistance());
        }
    }

    public bool isPlayerStopped()
    {
        return velocity.magnitude == 0;
    }

    private bool canDash()
    {
        return true;
    }

    IEnumerator DashDistance()
    {
        yield return new WaitForSeconds(DASH_DISTANCE);
        app.model.CurrentSpeed = app.model.Speed;
    }
}

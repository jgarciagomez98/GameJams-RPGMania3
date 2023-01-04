using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : PlayerElement
{
    private const float DASH_DISTANCE = 0.2f;
    private const float DASH_RECOVERY_TIME = 2f;

    private float horizontalAxis;
    private float verticalAxis;
    private Vector2 velocity;
    private bool isDashing;

    private Coroutine dashRecoveryCoroutine;

    private void Start()
    {
        app.model.CurrentSpeed = app.model.Speed;
        app.model.CurrentStamina = app.model.MaxStamina;
        isDashing = false;
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
            app.model.CurrentStamina--;
            isDashing = true;
            StartCoroutine(DashDistance());
        }
    }

    public bool isPlayerStopped()
    {
        return velocity.magnitude == 0;
    }

    private bool canDash()
    {
        return !isDashing && app.model.CurrentStamina > 0;
    }

    IEnumerator DashDistance()
    {
        yield return new WaitForSeconds(DASH_DISTANCE);
        app.model.CurrentSpeed = app.model.Speed;
        isDashing = false;
        StartRecoveryStamina();
    }

    private void StartRecoveryStamina()
    {
        if (dashRecoveryCoroutine != null)
        {
            StopCoroutine(dashRecoveryCoroutine);
        }
        dashRecoveryCoroutine = StartCoroutine(DashRecovery());
    }

    IEnumerator DashRecovery()
    {
        yield return new WaitForSeconds(DASH_RECOVERY_TIME);
        while (app.model.CurrentStamina < app.model.MaxStamina) {
            app.model.CurrentStamina++;
            yield return new WaitForSeconds(DASH_RECOVERY_TIME);
        }
        dashRecoveryCoroutine = null;
    }
}

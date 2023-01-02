using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : PlayerElement
{
    private const float DASH_TIME = 0.2f;
    private const float RESTORE_DASH_TIME = 2f;

    private float horizontalAxis;
    private float verticalAxis;
    private bool isDashing;
    private Coroutine restoreDashCoroutine;

    private void Update()
    {
        SetMovementAxis();
    }

    private void SetMovementAxis()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
    }

    public Vector2 OnPlayerMove()
    {
        return new Vector2(horizontalAxis * playerApplication.model.PlayerCurrentSpeed, verticalAxis * playerApplication.model.PlayerCurrentSpeed);
    }

    public void OnPlayerDash()
    {
        if (canDash())
        {
            playerApplication.model.PlayerCurrentSpeed = playerApplication.model.PlayerDashSpeed;
            isDashing = true;
            UseDashPoint();
            StartCoroutine(DashTime());
        }
    }

    private bool canDash()
    {
        return playerApplication.model.PlayerCurrentDashPoints > 0 && !isDashing;
    }

    private void UseDashPoint()
    {
        if (playerApplication.model.PlayerCurrentDashPoints - 1 <= 0)
        {
            playerApplication.model.PlayerCurrentDashPoints = 0;
        }
        else
        {
            playerApplication.model.PlayerCurrentDashPoints--;
        }
    }

    private void RestoreDash()
    {
        if (restoreDashCoroutine != null)
        {
            StopCoroutine(restoreDashCoroutine);
        }
        restoreDashCoroutine = StartCoroutine(RestoreDashPoint());
    }

    IEnumerator DashTime()
    {
        yield return new WaitForSeconds(DASH_TIME);
        playerApplication.model.PlayerCurrentSpeed = playerApplication.model.PlayerSpeed;
        isDashing = false;
        RestoreDash();
    }

    IEnumerator RestoreDashPoint()
    {
        yield return new WaitForSeconds(RESTORE_DASH_TIME);
        while (playerApplication.model.PlayerCurrentDashPoints < playerApplication.model.PlayerMaxDashPoints)
        {
            playerApplication.model.PlayerCurrentDashPoints++;
            yield return new WaitForSeconds(RESTORE_DASH_TIME);
        }
        restoreDashCoroutine = null;
    }

    public bool isPlayerStopped()
    {
        return playerApplication.model.PlayerCurrentSpeed == 0;
    }
}

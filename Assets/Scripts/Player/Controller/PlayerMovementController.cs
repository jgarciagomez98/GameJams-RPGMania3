using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : PlayerElement
{
    private const float DASH_TIME = 0.2f;

    private float horizontalAxis;
    private float verticalAxis;

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
        return new Vector2(horizontalAxis * playerApplication.playerModel.PlayerCurrentSpeed, verticalAxis * playerApplication.playerModel.PlayerCurrentSpeed);
    }

    public void OnPlayerDash()
    {
        if (canDash())
        {
            playerApplication.playerModel.PlayerCurrentSpeed = playerApplication.playerModel.PlayerDashSpeed;
            StartCoroutine(DashTime());
        }
    }

    private bool canDash()
    {
        return playerApplication.playerModel.PlayerCurrentDashPoints > 0;
    }

    private void UseDashPoint()
    {

    }

    IEnumerator DashTime()
    {
        yield return new WaitForSeconds(DASH_TIME);
        playerApplication.playerModel.PlayerCurrentSpeed = playerApplication.playerModel.PlayerSpeed;
    }
}

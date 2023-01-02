using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : PlayerElement
{
    private const float DASH_TIME = 0.2f;

    private float horizontalAxis;
    private float verticalAxis;
    private int currentPlayerSpeed;

    private void Start()
    {
        currentPlayerSpeed = playerApplication.playerModel.PlayerSpeed;
    }

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
        return new Vector2(horizontalAxis * currentPlayerSpeed, verticalAxis * currentPlayerSpeed);
    }

    public void OnPlayerDash()
    {
        if (canDash())
        {
            currentPlayerSpeed = playerApplication.playerModel.PlayerDashSpeed;
            StartCoroutine(DashTime());
        }
    }

    private bool canDash()
    {
        return true;
    }

    IEnumerator DashTime()
    {
        yield return new WaitForSeconds(DASH_TIME);
        currentPlayerSpeed = playerApplication.playerModel.PlayerSpeed;
    }
}

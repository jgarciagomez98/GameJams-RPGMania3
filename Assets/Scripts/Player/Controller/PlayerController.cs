using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PlayerElement
{
    void Start()
    {
        //Initialize all variables from model by default
        playerApplication.playerModel.PlayerCurrentSpeed = playerApplication.playerModel.PlayerSpeed;
        playerApplication.playerModel.PlayerCurrentDashPoints = playerApplication.playerModel.PlayerMaxDashPoints;
        playerApplication.playerModel.PlayerCurrentHitPoints = playerApplication.playerModel.PlayerMaxHitPoints;
    }
}

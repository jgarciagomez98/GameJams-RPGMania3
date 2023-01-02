using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PlayerElement
{
    void Start()
    {
        //Initialize all variables from model by default
        playerApplication.model.PlayerCurrentSpeed = playerApplication.model.PlayerSpeed;
        playerApplication.model.PlayerCurrentDashPoints = playerApplication.model.PlayerMaxDashPoints;
        playerApplication.model.PlayerCurrentHitPoints = playerApplication.model.PlayerMaxHitPoints;
    }
}

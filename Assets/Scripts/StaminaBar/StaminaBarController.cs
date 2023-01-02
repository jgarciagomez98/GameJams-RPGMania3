using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaBarController : PlayerElement
{
    public int getMaxStaminaPoints()
    {
        return playerApplication.model.PlayerMaxDashPoints;
    }
}

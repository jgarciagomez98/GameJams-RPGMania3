using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageController : PlayerElement
{
    void Start()
    {
        app.model.CurrentHitPoints = app.model.MaxHitPoints;
    }

    public void MakeDamage(int damageValue)
    {
        app.model.CurrentHitPoints -= damageValue;
        if (app.model.CurrentHitPoints > 0)
        {
            app.damageView.OnPlayerReceivedDamage();
        }
        else
        {
            app.damageView.OnPlayerDead();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootingController : PlayerElement
{
   public void OnLootingCoins(int value)
    {
        app.model.CurrentMoney += value;
    }
}

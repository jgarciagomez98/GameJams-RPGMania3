using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldController : PlayerElement
{
    public void OnUpdateGoldAmount()
    {
        app.goldView.UpdateGoldUI(app.model.CurrentMoney);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaBarController : PlayerElement
{
    public void OnUpdateSliderValue()
    {
        app.staminaBarView.OnSliderValueUpdated(app.model.CurrentStamina);
    }

    public int GetMaxValueSlider()
    {
        return app.model.MaxStamina;
    }
}

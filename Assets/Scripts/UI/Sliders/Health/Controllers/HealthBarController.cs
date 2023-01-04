using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : PlayerElement
{
    public void OnUpdateSliderValue()
    {
        app.healthBarView.OnSliderValueUpdated(app.model.CurrentHitPoints);
    }

    public int GetMaxValueSlider()
    {
        return app.model.MaxHitPoints;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : PlayerElement
{
    private Slider staminaSlider;
    private void Start()
    {
        staminaSlider = transform.GetComponent<Slider>();
        staminaSlider.maxValue = playerApplication.controllers.staminaBarController.getMaxStaminaPoints();
    }
}

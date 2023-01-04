using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBarView : PlayerElement
{
    private Slider slider;

    private void Start()
    {
        slider = transform.GetComponent<Slider>();
        slider.maxValue = app.staminaBarController.GetMaxValueSlider();
    }

    private void Update()
    {
        UpdateSliderValue();
    }

    protected void UpdateSliderValue()
    {
        app.staminaBarController.OnUpdateSliderValue();
    }

    public void OnSliderValueUpdated(int sliderValue)
    {
        slider.value = sliderValue;
    }
}

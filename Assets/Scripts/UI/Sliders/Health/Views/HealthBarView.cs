using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : PlayerElement
{
    private Slider slider;

    private void Start()
    {
        slider = transform.GetComponent<Slider>();
        slider.maxValue = app.healthBarController.GetMaxValueSlider();
    }

    private void Update()
    {
        UpdateSliderValue();
    }

    protected void UpdateSliderValue()
    {
        app.healthBarController.OnUpdateSliderValue();
    }

    public void OnSliderValueUpdated(int sliderValue)
    {
        slider.value = sliderValue;
    }
}

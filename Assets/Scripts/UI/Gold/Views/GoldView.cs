using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldView : PlayerElement
{
    private TextMeshProUGUI goldValue;
    // Start is called before the first frame update
    void Start()
    {
        goldValue = transform.GetComponent<TextMeshProUGUI>();
    }

    public void UpdateGoldAmount()
    {
        app.goldController.OnUpdateGoldAmount();
    }

    public void UpdateGoldUI(int value)
    {
        goldValue.text = value.ToString();
    }
}

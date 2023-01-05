using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsController : MonoBehaviour
{
    private int value;

    private void Start()
    {
        value = Random.Range(0, 10);
    }

    public int GetCoinValue()
    {
        return value;
    }
}

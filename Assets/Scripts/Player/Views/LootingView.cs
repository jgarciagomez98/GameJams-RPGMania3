using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootingView : PlayerElement
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coins")
        {
            app.lootingController.OnLootingCoins(collision.GetComponent<CoinsController>().GetCoinValue());
            Destroy(collision.gameObject);
        }
    }
}

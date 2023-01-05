using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootingView : PlayerElement
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coins")
        {
            //TODO: Call controller method and destroy coin game object
            //app.lootingController.OnLootingCoins(collision.GetComponent<>());
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAttackView : PlayerElement
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyDamageHitBox")
        {
            app.simpleAttackController.OnEnemyDamaged();
        }
    }
}

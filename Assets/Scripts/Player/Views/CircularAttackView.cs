using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularAttackView : PlayerElement
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyDamageHitBox")
        {
            app.circularAttackController.OnEnemyDamaged();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertSensorView : EnemyElement
{
    private bool isCollisionEnabled;
    private void Start()
    {
        isCollisionEnabled = false;
        transform.GetComponent<CircleCollider2D>().enabled = isCollisionEnabled;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            app.alertSensorController.OnPlayerEnter(collision.transform);
        }
    }

    public void OnToggleColliderEnabled()
    {
        isCollisionEnabled = !isCollisionEnabled;
        transform.GetComponent<CircleCollider2D>().enabled = isCollisionEnabled;
    }
}

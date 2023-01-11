using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximitySensorView : EnemyElement
{
    private bool isCollisionEnabled;

    private void Start()
    {
        isCollisionEnabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            app.proximitySensorController.OnPlayerEnter(collision.transform);
        }
    }

    public void DisableProximitySensor()
    {
        isCollisionEnabled = false;
        transform.GetComponent<CapsuleCollider2D>().enabled = isCollisionEnabled;
    }

    public void EnaableProximitySensor()
    {
        isCollisionEnabled = true;
        transform.GetComponent<CapsuleCollider2D>().enabled = isCollisionEnabled;
    }
}

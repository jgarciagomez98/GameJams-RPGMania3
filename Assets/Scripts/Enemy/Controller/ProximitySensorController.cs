using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximitySensorController : EnemyElement
{
    public void OnPlayerEnter(Transform playerTransform)
    {
        if (!app.model.IsInAlert)
        {
            app.model.PlayerTransform = playerTransform;
            app.lookingSensorController.OnPlayerEnterVisionArea(playerTransform);
            ToggleActivateCollider();
        }
    }

    private void ToggleActivateCollider()
    {
        app.proximitySensorView.OnToggleActivateCollider();
    }
}

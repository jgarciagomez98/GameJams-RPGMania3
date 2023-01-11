using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertSensorController : EnemyElement
{
    private Coroutine keepInAlertCoroutine;

    private void Start()
    {
        keepInAlertCoroutine = null; 
    }

    public void OnPlayerEnter(Transform playerTransform)
    {
        if (app.model.IsInAlert)
        {
            app.model.PlayerTransform = playerTransform;
            app.lookingSensorController.OnPlayerEnterVisionArea(playerTransform);
            ToggleActivateCollider();

            if (keepInAlertCoroutine != null)
            {
                StopCoroutine(keepInAlertCoroutine);
            }
        }
    }

    public void OnKeepInAlert()
    {
        ToggleActivateCollider();
        keepInAlertCoroutine = StartCoroutine(StopKeepInAlert());
    }

    private void ToggleActivateCollider()
    {
        app.AlertSensorView.OnToggleColliderEnabled();
    }

    IEnumerator StopKeepInAlert()
    {
        yield return new WaitForSeconds(app.model.SecondsInAlert);
        app.model.IsInAlert = false;
        keepInAlertCoroutine = null;
        ToggleActivateCollider();
        app.proximitySensorView.EnaableProximitySensor();

    }
}

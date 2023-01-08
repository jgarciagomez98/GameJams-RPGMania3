using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingSensorController : EnemyElement
{
    private const float ENEMY_KEEP_WATCHING_PLAYER = 3f;
    private Coroutine stopFollowPlayerCoroutine;

    void Start()
    {
        stopFollowPlayerCoroutine = null;
    }

    private void FixedUpdate()
    {
        if (app.model.PlayerTransform != null)
        {
            FollowPlayerWithVision();
        }
    }

    public void OnPlayerEnterVisionArea(Transform playerTransform)
    {
        app.model.PlayerTransform = playerTransform;
        app.model.IsInAlert = true;

        if (stopFollowPlayerCoroutine != null)
        {
            StopCoroutine(stopFollowPlayerCoroutine);
        }
    }

    public void OnPlayerExitVisionArea()
    {
        stopFollowPlayerCoroutine = StartCoroutine(StopFollowPlayer()); 
    }

    private void FollowPlayerWithVision()
    {
        app.lookingSensorView.OnPlayerFollowWithVision(app.model.PlayerTransform.position);
    }

    IEnumerator StopFollowPlayer()
    {
        yield return new WaitForSeconds(ENEMY_KEEP_WATCHING_PLAYER);
        CleanReference();
        KeepInAlert();
    }

    private void CleanReference()
    {
        stopFollowPlayerCoroutine = null;
        app.model.PlayerTransform = null;
    }

    private void KeepInAlert()
    {
        app.alertSensorController.OnKeepInAlert();
    }
}

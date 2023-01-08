using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingSensorController : EnemyElement
{
    private Transform playerTransform;
    private Coroutine stopFollowPlayerCoroutine;

    void Start()
    {
        playerTransform = null;
        stopFollowPlayerCoroutine = null;
    }

    private void FixedUpdate()
    {
        if (playerTransform != null)
        {
            FollowPlayerWithVision();
        }
    }

    public void OnPlayerEnterVisionArea(Transform playerTransform)
    {
        this.playerTransform = playerTransform;
        app.model.PlayerTransform = playerTransform;

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
        app.lookingSensorView.OnPlayerFollowWithVision(playerTransform.position);
    }

    IEnumerator StopFollowPlayer()
    {
        yield return new WaitForSeconds(3f);
        playerTransform = null;
        stopFollowPlayerCoroutine = null;
        app.model.PlayerTransform = null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    [SerializeField] PlayerMovementController player;
    public float offset, offsetSmoothing;
    private Vector3 playerPosition;

    private void FixedUpdate()
    {
        if (player != null)
        {
            playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);

            if (player.isPlayerStopped() || Vector3.Distance(this.transform.position, player.transform.position) > offset)
            {
                this.transform.position = Vector3.Lerp(this.transform.position, playerPosition, offsetSmoothing);
            }

        }
    }
}

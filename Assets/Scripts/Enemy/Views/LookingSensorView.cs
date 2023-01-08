using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingSensorView : EnemyElement
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            app.lookingSensorController.OnPlayerEnterVisionArea(collision.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            app.lookingSensorController.OnPlayerExitVisionArea();
        }
    }

    public void OnPlayerFollowWithVision(Vector3 position)
    {
        Vector3 pivotVector = transform.parent.position;
        pivotVector -= position;
        float angle = Mathf.Atan2(pivotVector.y, pivotVector.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAreaFollowCursor : MonoBehaviour
{
    private bool isAttacking = false;

    void Update()
    {
        followCursor();
    }

    private void followCursor()
    {
        if (!isAttacking)
        {
            Vector3 pivotVector = Camera.main.WorldToScreenPoint(transform.position);
            pivotVector -= Input.mousePosition;
            float angle = Mathf.Atan2(pivotVector.y, pivotVector.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
        }

    }
}

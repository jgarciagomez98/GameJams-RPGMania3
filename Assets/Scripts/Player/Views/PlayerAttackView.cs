using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackView : PlayerElement
{
    private const float SIMPLE_ATTACK_TIME = 0.15f;
    private const float CIRCULAR_ATTACK_TIME = 0.5f;

    private GameObject simpleAttackArea;
    private GameObject circularAttackArea;
    private bool isAttacking;

    private void Start()
    {
        simpleAttackArea = transform.GetChild(0).gameObject;
        circularAttackArea = transform.GetChild(1).gameObject;
        isAttacking = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            SimpleAttack();
        }

        if (Input.GetMouseButtonDown(1) && !isAttacking)
        {
            CircularAttack();
        }
    }

    private void SimpleAttack()
    {
        simpleAttackArea.SetActive(true);
        isAttacking = true;
        StartCoroutine(DisableSimpleAttackArea());
    }

    IEnumerator DisableSimpleAttackArea ()
    {
        yield return new WaitForSeconds(SIMPLE_ATTACK_TIME);
        simpleAttackArea.SetActive(false);
        isAttacking = false;
    }

    private void CircularAttack()
    {
        circularAttackArea.SetActive(true);
        isAttacking = true;
        StartCoroutine(DisableCircularAttackArea());
    }

    IEnumerator DisableCircularAttackArea()
    {
        yield return new WaitForSeconds(CIRCULAR_ATTACK_TIME);
        circularAttackArea.SetActive(false);
        isAttacking = false;
    }
}

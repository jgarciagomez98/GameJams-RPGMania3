using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackView : PlayerElement
{
    private GameObject simpleAttackArea;
    private GameObject circularAttackArea;

    private void Start()
    {
        simpleAttackArea = transform.GetChild(0).gameObject;
        circularAttackArea = transform.GetChild(1).gameObject;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SimpleAttack();
        }

        if (Input.GetMouseButtonDown(1))
        {
            CircularAttack();
        }
    }

    private void SimpleAttack()
    {
        simpleAttackArea.SetActive(true);
        StartCoroutine(DisableSimpleAttackArea());
    }

    IEnumerator DisableSimpleAttackArea ()
    {
        yield return new WaitForSeconds(0.35f);
        simpleAttackArea.SetActive(false);
    }

    private void CircularAttack()
    {
        circularAttackArea.SetActive(true);
        StartCoroutine(DisableCircularAttackArea());
    }

    IEnumerator DisableCircularAttackArea()
    {
        yield return new WaitForSeconds(0.55f);
        circularAttackArea.SetActive(false);
    }
}

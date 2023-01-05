using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyElement : MonoBehaviour
{
    public EnemyApplication app { get { return GameObject.FindObjectOfType<EnemyApplication>(); } }
}

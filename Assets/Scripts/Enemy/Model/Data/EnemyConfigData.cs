using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyConfigData", menuName = "Enemy/Config")]
public class EnemyConfigData : ScriptableObject
{
    public new string name;
    public int patrolSpeed;
    public int seekSpeed;
    public int dashSpeed;
    public int maxStamina;
    public int maxHitPoints;
    public int damage;
    public float secondsInAlert;
}

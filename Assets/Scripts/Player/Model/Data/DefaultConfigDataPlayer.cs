using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultConfigDataPlayer", menuName = "Player/DefaultConfig")]
public class DefaultConfigDataPlayer : ScriptableObject
{
    public new string name;
    public int speed;
    public int dashSpeed;
    public int maxStamina;
    public int maxHitPoints;
    public int damage;
}

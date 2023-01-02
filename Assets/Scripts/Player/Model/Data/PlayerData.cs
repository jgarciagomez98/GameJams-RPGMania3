using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/PlayerData")]
public class PlayerData : ScriptableObject
{
    public new string name;
    public int speed;
    public int dashSpeed;
    public int maxDashPoints;
    public int maxHitPoints;
    public int damage;
}

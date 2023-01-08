using UnityEngine;

public class EnemyModel : EnemyElement
{
    #region DefaultData
    [SerializeField] private EnemyConfigData enemyData;

    public string Name { get => enemyData.name; }
    public int PatrolSpeed { get => enemyData.patrolSpeed; }
    public int SeekSpeed { get => enemyData.seekSpeed; }
    public int DashSpeed { get => enemyData.dashSpeed; }
    public int MaxStamina { get => enemyData.maxStamina; }
    public int MaxHitPoints { get => enemyData.maxHitPoints; }
    public int Damage { get => enemyData.damage; }
    public float SecondsInAlert { get => enemyData.secondsInAlert; }
    #endregion

    #region InGameData
    private Transform playerTransform;
    private bool isInAlert;


    public Transform PlayerTransform { get => playerTransform; set => playerTransform = value; }
    public bool IsInAlert { get => isInAlert; set => isInAlert = value; }
    #endregion
}

using UnityEngine;

public class PlayerModel : PlayerElement
{
    #region DefaultPlayerData
    [SerializeField] private DefaultConfigDataPlayer defaultConfigData;

    public string Name { get => defaultConfigData.name; }
    public int Speed { get => defaultConfigData.speed; }
    public int DashSpeed { get => defaultConfigData.dashSpeed; }
    public int MaxStamina { get => defaultConfigData.maxStamina; }
    public int MaxHitPoints { get => defaultConfigData.maxHitPoints; }
    public int Damage { get => defaultConfigData.damage; }
    #endregion

    #region InGamePlayerData
    private int currentHitPoints;
    private int currentStamina;
    private int currentSpeed;
    private int currentMoney;

    public int CurrentHitPoints { get => currentHitPoints; set => currentHitPoints = value; }
    public int CurrentStamina { get => currentStamina; set => currentStamina = value; }
    public int CurrentSpeed { get => currentSpeed; set => currentSpeed = value; }
    public int CurrentMoney { get => currentMoney; set => currentMoney = value; }
    #endregion



}

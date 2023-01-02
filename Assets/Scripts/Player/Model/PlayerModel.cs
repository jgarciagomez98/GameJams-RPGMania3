using UnityEngine;

public class PlayerModel : PlayerElement
{
    #region OtherModels
    private WeaponModel weaponModel;
    #endregion

    #region PlayerDataAttributes
    [SerializeField] private PlayerData playerData;
    #endregion

    #region InGamePlayerAttributes
    private int playerCurrentHitPoints;
    private int playerCurrentDashPoints;
    private int playerCurrentSpeed;
    #endregion

    #region PlayerDataMethods
    public string PlayerName { get => playerData.name; set => playerData.name = value; }
    public int PlayerSpeed { get => playerData.speed; }
    public int PlayerDashSpeed { get => playerData.dashSpeed; }
    public int PlayerMaxDashPoints { get => playerData.maxDashPoints; }
    public int PlayerMaxHitPoints { get => playerData.maxHitPoints; }
    public int PlayerDamage { get => playerData.maxHitPoints; }
    #endregion

    #region InGamePlayerDataMethods
    public int PlayerCurrentHitPoints { get => playerCurrentHitPoints; set => playerCurrentHitPoints = value; }
    public int PlayerCurrentDashPoints { get => playerCurrentDashPoints; set => playerCurrentDashPoints = value; }
    public int PlayerCurrentSpeed { get => playerCurrentSpeed; set => playerCurrentSpeed = value; }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
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
    private int playerCurrentDashUses;
    #endregion

    #region PlayerDataMethods
    public string PlayerName { get => playerData.name; set => playerData.name = value; }
    public int PlayerSpeed { get => playerData.speed; }
    public int PlayerDashSpeed { get => playerData.dashSpeed; }
    public int PlayerMaxDashUses { get => playerData.maxDashUses; }
    public int PlayerMaxHitPoints { get => playerData.maxHitPoints; }
    public int PlayerDamage { get => playerData.maxHitPoints; }
    #endregion

    #region InGamePlayerDataMethods
    public int PlayerCurrentHitPoints { get => playerCurrentHitPoints; set => playerCurrentHitPoints = value; }
    public int PlayerCurrentDashUses { get => playerCurrentDashUses; set => playerCurrentDashUses = value; }
    #endregion
}

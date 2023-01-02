using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    #region OtherModels
    private WeaponModel weaponModel;
    #endregion

    #region PlayerDataAttributes
    [SerializeField] private PlayerData playerData;
    private string playerName;
    private int playerSpeed;
    private int playerDashSpeed;
    private int playerMaxDashUses;
    private int playerMaxHitPoints;
    private int playerDamage;
    #endregion

    #region InGamePlayerAttributes
    private int playerCurrentHitPoints;
    private int playerCurrentDashUses;
    #endregion

    #region PlayerDataMethods
    public string PlayerName { get => playerName; set => playerName = value; }
    public int PlayerSpeed { get => playerSpeed; }
    public int PlayerDashSpeed { get => playerDashSpeed; }
    public int PlayerMaxDashUses { get => playerMaxDashUses; }
    public int PlayerMaxHitPoints { get => playerMaxHitPoints; }
    public int PlayerDamage { get => playerDamage; }
    #endregion

    #region InGamePlayerDataMethods
    public int PlayerCurrentHitPoints { get => playerCurrentHitPoints; set => playerCurrentHitPoints = value; }
    public int PlayerCurrentDashUses { get => playerCurrentDashUses; set => playerCurrentDashUses = value; }
    #endregion

}

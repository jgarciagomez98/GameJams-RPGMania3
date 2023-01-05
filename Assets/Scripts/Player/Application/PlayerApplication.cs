using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerApplication : MonoBehaviour
{
    public PlayerModel model;

    [Header("Movement")]
    public PlayerMovementController movementController;
    public PlayerMovementView movementView;

    [Header("UI")]
    public StaminaBarController staminaBarController;
    public StaminaBarView staminaBarView;
    public HealthBarController healthBarController;
    public HealthBarView healthBarView;
    public GoldController goldController;
    public GoldView goldView;

    [Header("Damage")]
    public PlayerDamageController damageController;
    public PlayerDamageView damageView;

    [Header("Attack")]
    public PlayerAttackController attackController;
    public PlayerAttackView attackView;
    public SimpleAttackController simpleAttackController;
    public SimpleAttackView simpleAttackView;
    public CircularAttackController circularAttackController;
    public CircularAttackView circularAttackView;

    [Header("Looting")]
    public LootingController lootingController;
    public LootingView lootingView;
}
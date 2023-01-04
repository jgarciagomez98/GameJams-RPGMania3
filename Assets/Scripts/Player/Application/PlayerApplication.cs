using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerApplication : MonoBehaviour
{
    public PlayerModel model;

    [Header("Movement")]
    public PlayerMovementController movementController;
    public PlayerMovementView movementView;

    [Header("Sliders")]
    public StaminaBarController staminaBarController;
    public StaminaBarView staminaBarView;
    public HealthBarController healthBarController;
    public HealthBarView healthBarView;

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
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerApplication : MonoBehaviour
{
    public PlayerModel model;

    public PlayerMovementController movementController;
    public PlayerMovementView movementView;

    public StaminaBarController staminaBarController;
    public StaminaBarView staminaBarView;
}
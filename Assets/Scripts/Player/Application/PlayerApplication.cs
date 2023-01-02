using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerApplication : MonoBehaviour
{
    public PlayerModel model;
    public Controllers controllers;
    public Views views;
}

public class Controllers
{
    public PlayerMovementController movementController;
    public HealthBarController healthBarController;
    public StaminaBarController staminaBarController;
}

public class Views
{

}

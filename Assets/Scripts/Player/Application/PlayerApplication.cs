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
}

public class Views
{
    public PlayerMovementView movementView;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyApplication : MonoBehaviour
{
    public EnemyModel model;

    [Header("AI Sensors")]
    public LookingSensorController lookingSensorController;
    public LookingSensorView lookingSensorView;

    public AlertSensorController alertSensorController;
    public AlertSensorView AlertSensorView;

    public ProximitySensorController proximitySensorController;
    public ProximitySensorView proximitySensorView;
}

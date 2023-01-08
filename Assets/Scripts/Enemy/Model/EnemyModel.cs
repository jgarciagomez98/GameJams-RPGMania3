using UnityEngine;

public class EnemyModel : EnemyElement
{
    #region DefaultData

    #endregion

    #region InGameData
    private Transform playerTransform;


    public Transform PlayerTransform { get => playerTransform; set => playerTransform = value; }
    #endregion
}

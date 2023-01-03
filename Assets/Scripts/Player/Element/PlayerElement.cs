using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerElement : MonoBehaviour
{
   public PlayerApplication app { get { return GameObject.FindObjectOfType<PlayerApplication>(); } }
}

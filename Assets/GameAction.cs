using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameAction", order = 1)]
public class GameAction : ScriptableObject
{
    public Action<GameObject> Trigger;
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CardAction", order = 1)]
public class CardAction : ScriptableObject
{
    public Action<CardValue> Trigger;
}

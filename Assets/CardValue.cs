using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CardValue", order = 1)]
public class CardValue : ScriptableObject
{
    public int Mana;
    public bool DirectDamage;
    public float Damage;
    public CardValue Link;
}

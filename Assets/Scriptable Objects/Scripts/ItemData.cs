using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable
}

public enum ConsumableType
{
    Health
}

[System.Serializable]
public struct ItemDataConsumable
{
    public ConsumableType type;
    public float value;
}

public enum EquipAbleType
{
    Weapon,
    Armor,
    Trinkets
}

[System.Serializable]
public struct EquipAble
{
    public EquipAbleType type;
    public float atk;
    public float def;
    public float hp;
    public float crit;
}


[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public int cost;
    public ItemType type;
    public Sprite icon;
    //public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("ConsumAlbe")]
    public ItemDataConsumable[] consumables;

    [Header("EquipAble")]
    public EquipAble equipAble;
    //public GameObject equipPrefab;
}

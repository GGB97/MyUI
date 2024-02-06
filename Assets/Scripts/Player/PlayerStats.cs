using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public string ID;
    public string name;
    public string job;
    public int gold;

    public int level;
    public int maxExp;
    public int exp;

    [Header("Status")]
    public float atk;
    public float def;
    public float hp;
    public float crit;

    [Header("Item Status")]
    public float atkEquip;
    public float defEquip;
    public float hpEquip;
    public float critEquip;


    public void AddEquipSats(ItemObject item)
    {
        atkEquip += item.data.equipAble.atk;
        defEquip += item.data.equipAble.def;
        hpEquip += item.data.equipAble.hp;
        critEquip += item.data.equipAble.crit;
    }
    public void SubEquipSats(ItemObject item)
    {
        atkEquip -= item.data.equipAble.atk;
        defEquip -= item.data.equipAble.def;
        hpEquip -= item.data.equipAble.hp;
        critEquip -= item.data.equipAble.crit;
    }


    public bool Pay(int cost)
    {
        if (gold > cost) // �������� �����ؾ� �� �ݾ׺��� �������� ����.
            gold -= cost;
        else
            return false; // ������ �������� �ʰ� false�� ����

        return true;
    }
}

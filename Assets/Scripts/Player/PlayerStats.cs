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


    public bool Pay(int cost)
    {
        if (gold > cost) // 소지금이 지불해야 할 금액보다 많을떄만 차감.
            gold -= cost;
        else
            return false; // 적으면 차감하지 않고 false만 리턴

        return true;
    }
}

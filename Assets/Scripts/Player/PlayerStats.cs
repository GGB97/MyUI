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
}

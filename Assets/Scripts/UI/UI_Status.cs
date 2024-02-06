using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UI_Status : UI_Update
{
    [SerializeField] TMP_Text atkText;
    [SerializeField] TMP_Text defText;
    [SerializeField] TMP_Text healthText;
    [SerializeField] TMP_Text critText;

    public override void UpdateUI()
    {
        atkText.text = (player.atk + player.atkEquip).ToString();
        defText.text = (player.def + player.defEquip).ToString();
        healthText.text = (player.hp + player.hpEquip).ToString();
        critText.text = (player.crit + player.critEquip).ToString();
    }
}

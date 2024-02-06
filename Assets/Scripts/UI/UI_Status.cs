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
        atkText.text = player.atk.ToString();
        defText.text = player.def.ToString();
        healthText.text = player.hp.ToString();
        critText.text = player.crit.ToString();
    }
}

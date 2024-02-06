using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;



public class UI_Info : UI_Update
{
    [Header("Text")]
    [SerializeField] TMP_Text jobText;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text levelText;
    [SerializeField] TMP_Text expCurText;
    [SerializeField] TMP_Text expMaxText;
    [SerializeField] Image expBar;
    [SerializeField] TMP_Text goldText;

    public override void UpdateUI()
    {
        jobText.text = player.job;
        nameText.text = player.name;

        levelText.text = player.level.ToString();
        expCurText.text = player.exp.ToString();
        expMaxText.text = player.maxExp.ToString();
        expBar.fillAmount = (float)player.exp / (float)player.maxExp;

        goldText.text = player.gold.ToString("N0");
    }
}

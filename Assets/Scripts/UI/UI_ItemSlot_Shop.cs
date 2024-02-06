using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ItemSlot_Shop : MonoBehaviour, UI_Update_Interface
{
    public ItemObject itemObj;

    [SerializeField] Image icon;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text descText;
    [SerializeField] TMP_Text atkText;
    [SerializeField] TMP_Text defText;
    [SerializeField] TMP_Text hpText;
    [SerializeField] TMP_Text critText;
    [SerializeField] TMP_Text costText;

    Button btn;

    private void Awake()
    {
        btn = GetComponentInChildren<Button>(); // 나중에 구매or판매 버튼 연결 해야함.
    }

    public void UpdateUI()
    {
        icon.sprite = itemObj.data.icon;
        nameText.text = itemObj.data.displayName;
        descText.text = itemObj.data.description;

        SetValueText(atkText, itemObj.data.equipAble.atk);
        SetValueText(defText, itemObj.data.equipAble.def);
        SetValueText(hpText, itemObj.data.equipAble.hp);
        SetValueText(critText, itemObj.data.equipAble.crit);
    }

    void SetValueText(TMP_Text valueText, float value)
    {
        if (value != 0)
            valueText.text = value.ToString();

        valueText.transform.parent.gameObject.SetActive(value != 0); // +든 -든 0만 아니면 표시하게
    }
}

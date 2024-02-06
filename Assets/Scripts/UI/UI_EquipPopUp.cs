using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_EquipPopUp : MonoBehaviour
{
    [SerializeField] Image itemIcon;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text descText;

    [SerializeField] TMP_Text atkText;
    [SerializeField] TMP_Text defText;
    [SerializeField] TMP_Text hpText;
    [SerializeField] TMP_Text critText;

    [SerializeField] TMP_Text questionText;

    public Button[] buttons;

    [SerializeField] Button confirmBtn;
    [SerializeField] Button cancleBtn;

    private void Awake()
    {
        buttons = GetComponentsInChildren<Button>();
    }

    private void Start()
    {
        buttons[1].onClick.AddListener(() => UIManager.instance.CloseUI(this.gameObject));
    }

    public void Init(ItemObject obj)
    {
        itemIcon.sprite = obj.data.icon;
        nameText.text = obj.data.displayName;
        descText.text = obj.data.description;

        atkText.text = obj.data.equipAble.atk.ToString();
        defText.text = obj.data.equipAble.def.ToString();
        hpText.text = obj.data.equipAble.hp.ToString();
        critText.text = obj.data.equipAble.crit.ToString();

        // questionText �� ���� ���ο� ���� �ؽ�Ʈ ����
        if (obj.isEquiped)
        {
            questionText.text = "���� ���� �Ͻðڽ��ϱ�?";
        }
        else
        {
            questionText.text = "���� �Ͻðڽ��ϱ�?";
        }

        // ��ư 0���� ���� ���ο� ���� �Լ� ���� �ؾ���.
        buttons[0].onClick.RemoveAllListeners(); // �������� ������ ������ ����ߴ� �̺�Ʈ�� ���� �����.
        buttons[0].onClick.AddListener(() => AddConfirmBtn(obj));
        Debug.Log("init");
    }

    void AddConfirmBtn(ItemObject obj)
    {
        if(obj.isEquiped)
            UIManager.instance.player.GetComponent<PlayerEquipTool>().UnEquip(obj);
        else
            UIManager.instance.player.GetComponent<PlayerEquipTool>().Equip(obj);

        UIManager.instance.uiList[1].GetComponent<UI_Update_Interface>().UpdateUI();

        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum uiList
{
    info,
    stats,
    inven,
    shop
}

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject player; // GameManager�� �ִٸ� �ű⿡ �ְ������ ������ ���ӸŴ����� ������� �ʾƼ� �׳� ���⿡�ٰ�

    [Header("Object")]
    [SerializeField] public List<GameObject> uiList;
    [SerializeField] GameObject btnGroup;

    [Header("PopUp UI")]
    [SerializeField] GameObject equipPopUpUI;

    private void Awake()
    {
        instance = this;
    }

    public void OpenUI(GameObject obj)
    {
        //foreach (GameObject go in uiList)     // �̰� �޴� ��ư�� ����� uiâ�� �ϳ��� �����ְ� �ϰ� ���� �� ���
        //{     
        //    if (go == obj)
        //        go.SetActive(!obj.activeSelf);
        //    else
        //        go.SetActive(false);
        //}

        obj.SetActive(!obj.activeSelf);

        btnGroup.SetActive(false);
    }

    public void CloseUI(GameObject obj)
    {
        obj.SetActive(false);

        btnGroup.SetActive(true);
    }

    public void OpenPopUp(UI_ItemSlot item)
    {
        switch (item.itemObj.data.type)
        {
            case ItemType.Equipable:
                EquipPopUp(item);
                break;
            case ItemType.Consumable:
                break;
        }
    }

    void EquipPopUp(UI_ItemSlot item)
    {
        equipPopUpUI.SetActive(true);

        equipPopUpUI.GetComponent<UI_EquipPopUp>().Init(item.itemObj);
    }
}

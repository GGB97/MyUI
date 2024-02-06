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

    public GameObject player; // GameManager가 있다면 거기에 넣고싶지만 지금은 게임매니저를 사용하지 않아서 그냥 여기에다가

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
        //foreach (GameObject go in uiList)     // 이건 메뉴 버튼을 남기고 ui창은 하나만 열려있게 하고 싶을 때 사용
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

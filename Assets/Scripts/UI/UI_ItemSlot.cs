using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UI_ItemSlot : MonoBehaviour, UI_Update_Interface
{
    public ItemObject itemObj;
    Image image;
    TMP_Text equipTextObj;

    private void Awake()
    {
        image = GetComponent<Image>();
        equipTextObj = GetComponentInChildren<TMP_Text>();
    }

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => UIManager.instance.OpenPopUp(this));
    }

    public void UpdateUI()
    {
        if (itemObj == null)
            return;

        image.sprite = itemObj.data.icon;
        image.color = Color.white;
        //equipTextObj.gameObject.SetActive(itemObj.isEquiped);
    }
}

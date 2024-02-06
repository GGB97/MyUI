using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UI_ItemSlot : MonoBehaviour, UI_Update_Interface
{
    public ItemData data;
    public int index;
    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void UpdateUI()
    {
        if (data == null)
            return;

        image.sprite = data.icon;
        image.color = Color.white;
    }


}

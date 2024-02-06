using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UI_Inventory : MonoBehaviour, UI_Update_Interface
{
    [SerializeField] GameObject content;
    UI_ItemSlot[] uiSlots;
    
    Inventory playerInven;

    void Awake()
    {
        uiSlots = content.GetComponentsInChildren<UI_ItemSlot>();
    }

    private void OnEnable()
    {
        if (playerInven != null)
            UpdateUI();
    }

    void Start()
    {
        playerInven = UIManager.instance.player.GetComponent<Inventory>();

        UpdateUI();
    }

    public void UpdateUI()
    {
        for (int i = 0; i < uiSlots.Length; i++)
        {
            //uiSlots[i].itemObj.index = playerInven.items[i].index;
            uiSlots[i].itemObj = playerInven.items[i];

            if(playerInven.items[i].data != null)
            {
                uiSlots[i].itemObj.data = playerInven.items[i].data;
            }

            uiSlots[i].UpdateUI();
        }
    }
}

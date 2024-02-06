using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UI_Shop : MonoBehaviour, UI_Update_Interface
{
    [SerializeField] RectTransform content;
    [SerializeField] Shop shop;
    List<GameObject> slots;

    [SerializeField] GameObject slotPrefab;


    private void Awake()
    {
        slots = new List<GameObject>();
    }

    private void OnEnable()
    {
        UpdateUI();
    }

    void Init()
    {
        // 현재 슬롯 수가 상점의 판매목록 수보다 작을때 슬롯 수를 늘리기.
        if (slots.Count < shop.items.Count)
        {
            while (slots.Count < shop.items.Count)
            {
                slots.Add(Instantiate(slotPrefab, content.transform));
            }
        }

        // 반대로 슬롯 수가 더 많을 때 줄이기.
        if (slots.Count > shop.items.Count)
        {
            while (slots.Count > shop.items.Count)
            {
                Destroy(slots[slots.Count - 1].gameObject); // 이걸 먼저 하니까 에러나옴
                slots.RemoveAt(slots.Count - 1);
            }
        }

        // content의 height를 슬롯 수에 맞게 조정.
        content.sizeDelta = new Vector2(content.sizeDelta.x, slots.Count * 160f);
    }


    public void UpdateUI()
    {
        UI_ItemSlot_Shop itemSlot;

        Init();

        for (int i = 0; i < slots.Count; i++)
        {
            itemSlot = slots[i].GetComponent<UI_ItemSlot_Shop>();
            itemSlot.itemObj = shop.items[i];
            itemSlot.UpdateUI();
        }
    }
}

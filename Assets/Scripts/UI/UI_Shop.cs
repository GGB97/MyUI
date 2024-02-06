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
        // ���� ���� ���� ������ �ǸŸ�� ������ ������ ���� ���� �ø���.
        if (slots.Count < shop.items.Count)
        {
            while (slots.Count < shop.items.Count)
            {
                slots.Add(Instantiate(slotPrefab, content.transform));
            }
        }

        // �ݴ�� ���� ���� �� ���� �� ���̱�.
        if (slots.Count > shop.items.Count)
        {
            while (slots.Count > shop.items.Count)
            {
                Destroy(slots[slots.Count - 1].gameObject); // �̰� ���� �ϴϱ� ��������
                slots.RemoveAt(slots.Count - 1);
            }
        }

        // content�� height�� ���� ���� �°� ����.
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

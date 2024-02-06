using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemObject[] items = new ItemObject[30];

    private void Awake()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
                items[i] = new ItemObject();

            items[i].index = i;
        }
    }

    public void AddItem(ItemObject item)
    {
        items[GetNullIndex()] = item;
        item.transform.SetParent(UIManager.instance.player.transform, false);

    }

    int GetNullIndex()
    {
        int index = 0;
        foreach (ItemObject item in items)
        {
            if (item == null)
                break;
            index++;
        }

        return index;
    }

}

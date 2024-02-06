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
}

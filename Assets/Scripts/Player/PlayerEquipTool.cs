using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipTool : MonoBehaviour
{
    public ItemObject curWeapon;
    public ItemObject curArmor;
    public ItemObject curTrinkets; // ��ű��� 2���̻� ���� ���� �ϰ� �� ���� �־ �Ʒ� �ڵ带 �����ϰ� ���̷��ٰ� �ϴ� ����..


    public void Equip(ItemObject item)
    {
        switch (item.data.equipAble.type)
        {
            case EquipAbleType.Weapon:

                if (curWeapon != null)
                    UnEquip(curWeapon);

                curWeapon = item;
                curWeapon.isEquiped = true;

                break;

            case EquipAbleType.Armor:

                if (curArmor != null)
                    UnEquip(curArmor);

                curArmor = item;
                curArmor.isEquiped = true;

                break;

            case EquipAbleType.Trinkets:

                if (curTrinkets != null)
                    UnEquip(curTrinkets);

                curTrinkets = item;
                curTrinkets.isEquiped = true;

                break;
        }
    }

    public void UnEquip(ItemObject item)
    {
        switch (item.data.equipAble.type)
        {
            case EquipAbleType.Weapon:
                item.isEquiped = false;
                curWeapon = null;
                break;
            case EquipAbleType.Armor:
                item.isEquiped = false;
                curArmor = null;
                break;
            case EquipAbleType.Trinkets:
                item.isEquiped = false;
                curArmor = null;
                break;
        }
    }
}

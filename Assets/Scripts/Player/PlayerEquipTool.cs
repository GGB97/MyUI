using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipTool : MonoBehaviour
{
    public ItemObject curWeapon;
    public ItemObject curArmor;
    public ItemObject curTrinkets; // 장신구는 2개이상 착용 가능 하게 할 수도 있어서 아래 코드를 간략하게 줄이려다가 일단 냅둠..


    public void Equip(ItemObject item)
    {
        switch (item.data.equipAble.type)
        {
            case EquipAbleType.Weapon:

                if (curWeapon != null)
                    UnEquip(curWeapon);

                curWeapon = item;
                curWeapon.isEquiped = true;
                UIManager.instance.player.GetComponent<PlayerStats>().AddEquipSats(curWeapon);

                break;

            case EquipAbleType.Armor:

                if (curArmor != null)
                    UnEquip(curArmor);

                curArmor = item;
                curArmor.isEquiped = true; 
                UIManager.instance.player.GetComponent<PlayerStats>().AddEquipSats(curArmor);

                break;

            case EquipAbleType.Trinkets:

                if (curTrinkets != null)
                    UnEquip(curTrinkets);

                curTrinkets = item;
                curTrinkets.isEquiped = true;
                UIManager.instance.player.GetComponent<PlayerStats>().AddEquipSats(curTrinkets);

                break;
        }
    }

    public void UnEquip(ItemObject item)
    {
        switch (item.data.equipAble.type)
        {
            case EquipAbleType.Weapon:
                UIManager.instance.player.GetComponent<PlayerStats>().SubEquipSats(curWeapon);
                item.isEquiped = false;
                curWeapon = null;
                break;
            case EquipAbleType.Armor:
                UIManager.instance.player.GetComponent<PlayerStats>().SubEquipSats(curArmor);
                item.isEquiped = false;
                curArmor = null;
                break;
            case EquipAbleType.Trinkets:
                UIManager.instance.player.GetComponent<PlayerStats>().SubEquipSats(curTrinkets);
                item.isEquiped = false;
                curTrinkets = null;
                break;
        }
    }
}

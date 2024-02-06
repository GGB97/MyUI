using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Shop : MonoBehaviour
{
    public static Shop instance;

    // ������ �迭 ���� ����Ʈ�� �ϴ� ����
    // ���� �Ǹű���� ������ �÷��̾ �������� �Ǹ��Ѵٸ� �� �������� �߰��ϱ� ���ؼ�.
    // �뷮�� �����صθ� ���� �÷��̾ �������� �ѹ��� �ִ� �뷮 �Ѱ� �Ǹ��Ѵٸ� ������ ���°� �����ϱ� ���ؼ�?
    public List<ItemObject> items;

    Inventory playerInven;
    PlayerStats playerStats;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        playerInven = UIManager.instance.player.GetComponent<Inventory>();
        playerStats = UIManager.instance.player.GetComponent<PlayerStats>();
    }


    public void Buy(ItemObject item)
    {
        // ������ �������� �ȷ��� ��� ����Ʈ�� �ٿ��� ��.
        if (playerStats.Pay(item.data.cost))
        {
            playerInven.AddItem(item);
            items.Remove(item);

            UIManager.instance.uiList[(int)uiList.info].GetComponent<UI_Update_Interface>().UpdateUI();
            UIManager.instance.uiList[(int)uiList.shop].GetComponent<UI_Update_Interface>().UpdateUI();

            Debug.Log("���� �Ϸ�");
        }
        else
        {
            Debug.Log("�����ݾ� ����!!");
        }
    }

    public void Sell(ItemObject item)
    {
        // player���Լ� �� �������� ��� �ε����� �����Ǿ� ��������. �׷��� �װɷ� �÷��̾��� ���濡��
        // �������� �������� �������� �ڽ�Ʈ��ŭ �÷��̾��� �������� �÷��ָ� �ɵ�?
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Shop : MonoBehaviour
{
    public static Shop instance;

    // 상점은 배열 말고 리스트로 하는 이유
    // 아직 판매기능은 없지만 플레이어가 아이템을 판매한다면 그 아이템을 추가하기 위해서.
    // 용량을 제한해두면 만약 플레이어가 아이템을 한번에 최대 용량 넘게 판매한다면 에러가 나는걸 방지하기 위해서?
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
        // 상점의 아이템이 팔렸을 경우 리스트를 줄여야 함.
        if (playerStats.Pay(item.data.cost))
        {
            playerInven.AddItem(item);
            items.Remove(item);

            UIManager.instance.uiList[(int)uiList.info].GetComponent<UI_Update_Interface>().UpdateUI();
            UIManager.instance.uiList[(int)uiList.shop].GetComponent<UI_Update_Interface>().UpdateUI();

            Debug.Log("구매 완료");
        }
        else
        {
            Debug.Log("소지금액 부족!!");
        }
    }

    public void Sell(ItemObject item)
    {
        // player에게서 온 아이템의 경우 인덱스가 지정되어 있을거임. 그래서 그걸로 플레이어의 가방에서
        // 상점으로 가져오고 아이템의 코스트만큼 플레이어의 소지금을 늘려주면 될듯?
    }
}

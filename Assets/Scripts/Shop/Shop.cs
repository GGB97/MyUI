using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // 상점은 배열 말고 리스트로 하는 이유
    // 아직 판매기능은 없지만 플레이어가 아이템을 판매한다면 그 아이템을 추가하기 위해서.
    // 용량을 제한해두면 만약 플레이어가 아이템을 한번에 최대 용량 넘게 판매한다면 에러가 나는걸 방지하기 위해서?
    public List<ItemObject> items; 

    public void Buy(ItemObject item)
    {
        // 상점의 아이템이 팔렸을 경우 리스트를 줄여야 함.
    }
}

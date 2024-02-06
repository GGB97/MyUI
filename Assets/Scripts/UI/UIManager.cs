using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject player;

    [Header("Object")]
    [SerializeField] List<GameObject> uiList;
    [SerializeField] GameObject btnGroup;

    private void Awake()
    {
        instance = this;
    }

    public void OpenUI(GameObject obj)
    {
        //foreach (GameObject go in uiList)     // 이건 메뉴 버튼을 남기고 ui창은 하나만 열려있게 하고 싶을 때 사용
        //{     
        //    if (go == obj)
        //        go.SetActive(!obj.activeSelf);
        //    else
        //        go.SetActive(false);
        //}

        obj.SetActive(!obj.activeSelf);

        btnGroup.SetActive(false);
    }

    public void CloseUI(GameObject obj)
    {
        obj.SetActive(false);

        btnGroup.SetActive(true);
    }
}

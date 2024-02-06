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
        //foreach (GameObject go in uiList)     // �̰� �޴� ��ư�� ����� uiâ�� �ϳ��� �����ְ� �ϰ� ���� �� ���
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

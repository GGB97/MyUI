using UnityEngine;
using UnityEngine.UI;

public class UI_ItemSlot : MonoBehaviour, UI_Update_Interface
{
    public ItemObject itemObj;
    Image image;
    [SerializeField] GameObject equipTextObj;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => UIManager.instance.OpenPopUp(this));
    }

    public void UpdateUI()
    {
        if (itemObj == null)
        {
            equipTextObj.SetActive(false);
            return;
        }

        image.sprite = itemObj.data.icon;
        image.color = Color.white;
        equipTextObj.SetActive(itemObj.isEquiped);

    }
}

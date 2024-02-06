using UnityEngine;

public class UI_Update : MonoBehaviour, UI_Update_Interface
{
    protected PlayerStats player;

    protected virtual void OnEnable()
    {
        if (player != null)
            UpdateUI();
    }

    protected virtual void Start()
    {
        player = UIManager.instance.player.GetComponent<PlayerStats>();

        UpdateUI();
    }

    public virtual void UpdateUI() { }
}

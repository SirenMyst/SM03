using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : ShiMonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance => instance;

    [SerializeField] protected ItemManager itemManager;
    public ItemManager ItemManager => itemManager;

    protected override void Awake()
    {
        base.Awake();
        if (GameManager.instance != null) Debug.LogError("Only 1 GameManager allow to exist!");
        GameManager.instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemManager();
    }

    protected virtual void LoadItemManager()
    {
        if (this.itemManager != null) return;
        this.itemManager = transform.GetComponent<ItemManager>();
        Debug.LogWarning(transform.name + ": LoadItemManager", gameObject);
    }
}

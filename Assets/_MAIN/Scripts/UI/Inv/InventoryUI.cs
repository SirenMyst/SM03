using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : ShiMonoBehaviour
{
    public GameObject invPanel;
    public Player player;
    public List<SlotUI> slots = new List<SlotUI>();

    protected virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            this.ToggleInv();
        }
    }

    public virtual void ToggleInv()
    {
        if (!this.invPanel.activeSelf)
        {
            this.invPanel.SetActive(true);
            this.Setup();
        }
        else
        {
            this.invPanel.SetActive(false);
        }
    }

    protected virtual void Setup()
    {
        if (this.slots.Count == player.inv.slots.Count)
        {
            for (int i = 0; i < this.slots.Count; i++)
            {
                if (this.player.inv.slots[i].type != CollectableType.noType)
                {
                    this.slots[i].SetItem(this.player.inv.slots[i]);
                }
                else
                {
                    this.slots[i].SetEmpty();
                }
            }
        }
    }
}

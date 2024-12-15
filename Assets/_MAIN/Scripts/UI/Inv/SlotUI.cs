using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotUI : ShiMonoBehaviour
{
    public Image itemIcon;
    public TextMeshProUGUI quantityText;

    public virtual void SetItem(Inventory.Slot slot)
    {
        if (slot != null)
        {
            this.itemIcon.sprite = slot.icon;
            this.itemIcon.color = new Color(1, 1, 1, 1);
            this.quantityText.text = slot.count.ToString();
        }
    }

    public virtual void SetEmpty()
    {
        this.itemIcon.sprite = null;
        this.itemIcon.color = new Color(1, 1, 1, 0);
        this.quantityText.text = "";
    }
}

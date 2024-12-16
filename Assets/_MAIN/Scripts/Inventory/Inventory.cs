using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    [System.Serializable]
    public class Slot
    {
        public CollectableType type;
        public int count;
        public int maxAllowed;

        public Sprite icon;
        
        public Slot()
        {
            this.type = CollectableType.noType;
            this.count = 0;
            this.maxAllowed = 99; 
        }

        public virtual bool CanAddItem()
        {
            if (this.count < this.maxAllowed) return true;
            return false;
        }

        public virtual void AddItem(Collectable item)
        {
            this.type = item.type;
            this.icon = item.icon;

            this.count++;
        }

        public virtual void RemoveItem()
        {
            if (this.count <= 0) return;
            this.count--;
            if (this.count != 0) return;
            this.icon = null;
            this.type = CollectableType.noType;
        }
    }

    public List<Slot> slots = new List<Slot>();

    public Inventory(int numSlots)
    {
        for (int i = 0; i < numSlots; i++)
        {
            Slot slot = new Slot();
            this.slots.Add(slot);
        }
    }

    public virtual void Add(Collectable item)
    {
        foreach(Slot slot in slots)
        {
            if (slot.type == item.type && slot.CanAddItem())
            {
                slot.AddItem(item);
                return;
            }
        }

        foreach(Slot slot in slots)
        {
            if (slot.type == CollectableType.noType)
            {
                slot.AddItem(item);
                return;
            }
        }
    }

    public virtual void Remove(int index)
    {
        this.slots[index].RemoveItem();
    }
}

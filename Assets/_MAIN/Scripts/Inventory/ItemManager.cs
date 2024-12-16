using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : ShiMonoBehaviour
{
    public Collectable[] collectableItems;
    
    private Dictionary<CollectableType, Collectable> collectableItemsDict = 
        new Dictionary<CollectableType, Collectable>();
    
    protected override void Awake()
    {
        base.Awake();
        foreach(Collectable item in collectableItems)
        {
            this.AddItem(item);
        }
    }

    protected virtual void AddItem(Collectable item)
    {
        if (!this.collectableItemsDict.ContainsKey(item.type))
        {
            this.collectableItemsDict.Add(item.type, item);
        }
    }

    public virtual Collectable GetItemByType(CollectableType type)
    {
        if (this.collectableItemsDict.ContainsKey(type))
        {
            return this.collectableItemsDict[type];
        }
        return null;
    }
}

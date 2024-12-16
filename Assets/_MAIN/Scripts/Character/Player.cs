using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ShiMonoBehaviour
{
    public Inventory inv;

    protected override void Awake()
    {
        base.Awake();
        inv = new Inventory(21);
    }

    public virtual void DropItem(Collectable item)
    {
        Vector2 spawnPos = transform.position;

        Vector2 spawnOffSet = Random.insideUnitCircle * 1.25f;

        Collectable droppedItem = Instantiate(item, spawnPos + spawnOffSet, Quaternion.identity);

        droppedItem.body.AddForce(spawnOffSet * .2f, ForceMode2D.Impulse);
    }
}

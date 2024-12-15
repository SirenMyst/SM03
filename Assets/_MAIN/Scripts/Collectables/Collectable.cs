using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : ShiMonoBehaviour
{
    public CollectableType type;
    public Sprite icon;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Player player = col.GetComponent<Player>();
        if (player)
        {
            player.inv.Add(this);
            Destroy(this.gameObject);
        }
    }
}

public enum CollectableType
{
    noType,
    Grain_Seed
}
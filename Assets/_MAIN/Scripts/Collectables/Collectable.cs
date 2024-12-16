using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : ShiMonoBehaviour
{
    public CollectableType type;
    public Sprite icon;
    public Rigidbody2D body;

    protected override void Awake()
    {
        base.Awake();
        this.LoadBody();
    }
    protected virtual void LoadBody()
    {
        if (this.body != null) return;
        this.body = transform.GetComponent<Rigidbody2D>();
        Debug.LogWarning(transform.name + ": LoadBody", gameObject);
    }

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
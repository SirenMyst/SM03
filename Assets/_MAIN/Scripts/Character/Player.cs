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
}

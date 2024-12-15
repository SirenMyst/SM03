using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : ShiMonoBehaviour
{
    [SerializeField] protected Rigidbody2D body;
    [SerializeField] protected CharAnimation animChar;

    [SerializeField] protected float speed;
    [SerializeField] protected Vector2 moveDir;

    #region L&C
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBody();
    }
    protected virtual void LoadBody()
    {
        if (this.body != null) return;
        this.body = transform.parent.GetComponent<Rigidbody2D>();
        Debug.LogWarning(transform.name + "LoadBody", gameObject);
    }
    #endregion
    protected virtual void Update()
    {
        this.Moving();
        this.ReadAnimation();
    }

    protected virtual void Moving()
    {
        this.moveDir = InputManager.Instance.MoveDir;
        this.body.MovePosition(this.body.position + this.moveDir * (this.speed * Time.deltaTime));
        
    }

    protected virtual void ReadAnimation()
    {
        if (this.moveDir == Vector2.zero)
        {
            this.animChar.SetMoveBool(false);
            return;
        }
        this.animChar.SetMoveBool(true);
        this.animChar.SetMoveAnimation(this.moveDir);
       
    }
}

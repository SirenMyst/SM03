using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimation : ShiMonoBehaviour
{
    [SerializeField] protected Animator anim;
    [SerializeField] protected Vector2 moveDir;

    private readonly int moveX = Animator.StringToHash("MoveX");
    private readonly int moveY = Animator.StringToHash("MoveY");
    private readonly int moving = Animator.StringToHash("Moving");

    public virtual void SetMoveBool(bool value)
    {
        this.anim.SetBool(moving, value);
    }
    public virtual void SetMoveAnimation(Vector2 moveDir)
    {
        this.anim.SetFloat(moveX, moveDir.x);
        this.anim.SetFloat(moveY, moveDir.y);
    }
}

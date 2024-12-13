using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : ShiMonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance => instance;

    [SerializeField] protected Vector2 moveDir;
    public Vector2 MoveDir => moveDir;

    protected override void Awake()
    {
        base.Awake();
        if (InputManager.instance != null) Debug.LogError("Only 1 InputManager allow to exist!");
        InputManager.instance = this;
    }

    protected virtual void Update()
    {
        this.GetMoveInput();
    }

    protected virtual void GetMoveInput()
    {
        this.moveDir.x = Input.GetAxis("Horizontal");
        this.moveDir.y = Input.GetAxis("Vertical");
    }

}

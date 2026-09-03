using System;

public class PlayerInput
{
    public PlayerActions PlayerControl { get; private set; }

    public Action OnJumpStarted;
    public Action OnJumpCanceled;

    public PlayerInput()
    {
        PlayerControl = new PlayerActions();

        PlayerControl.BasicMap.Jump.started += ctx => OnJumpStarted();
        PlayerControl.BasicMap.Jump.canceled += ctx => OnJumpCanceled();

        PlayerControl.Enable();
    }
}

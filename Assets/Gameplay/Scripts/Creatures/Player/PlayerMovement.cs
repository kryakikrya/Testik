using UnityEngine;

public class PlayerMovement
{
    private bool _isJumping = false;
    private Rigidbody2D _rb;

    public PlayerMovement(PlayerInput input, Rigidbody2D rb)
    {
        input.OnJumpStarted += Jump;
        input.OnJumpCanceled += StopJump;

        _rb = rb;
    }

    public void Move(float force)
    {
        if (_isJumping)
        {
            _rb.AddForceY(force);
        }
    }

    private void Jump()
    {
        _isJumping = true;
    }

    private void StopJump()
    {
        _isJumping = false;
    }
}

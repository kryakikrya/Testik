using UnityEngine;

public class CoinMovement
{
    private Rigidbody2D _rb;

    public CoinMovement(Rigidbody2D rb)
    {
        _rb = rb;
    }

    public void Move(float horizontalSpeed)
    {
        _rb.linearVelocityX = -horizontalSpeed;
    }
}

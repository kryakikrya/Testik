using UnityEngine;

public class CoinMovement
{
    private Rigidbody2D _rb;
    private Transform _player;

    public CoinMovement(Rigidbody2D rb, Transform player)
    {
        _rb = rb;
        _player = player;
    }

    public void Move(float horizontalSpeed)
    {
        _rb.linearVelocityX = -horizontalSpeed;

        _rb.linearVelocityY = (_player.position.y - _rb.position.y) / Vector2.Distance(_player.position, _rb.position) / Vector2.Distance(_player.position, _rb.position);
    }
}

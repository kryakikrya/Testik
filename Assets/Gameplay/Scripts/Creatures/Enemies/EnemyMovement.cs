using UnityEngine;

public class EnemyMovement
{
    private bool _isJumping = false;

    private Rigidbody2D _rb;
    private Transform _player;
    private Transform _me;

    private int _stopDistance;

    public EnemyMovement(Transform player, Transform me, Rigidbody2D rb, int stopDistance)
    {
        _player = player;
        _me = me;
        _rb = rb;
        _stopDistance = stopDistance;
    }

    public void Move(float force, float horizontalSpeed)
    {
        float distanceY = Mathf.Abs(_me.position.y - _player.position.y);

        if (distanceY > _stopDistance)
        {
            if (_me.position.y < _player.position.y)
            {
                _rb.AddForceY(force);
            }
        }
        else if (Mathf.Abs(_rb.linearVelocityY) > 4f)
        {
            _rb.linearVelocityY = Mathf.Lerp(_rb.linearVelocityY, 0f, Time.fixedDeltaTime);
        }

        _rb.linearVelocityY = Mathf.Clamp(_rb.linearVelocityY, -6f, 6f);

        _rb.linearVelocityX = -horizontalSpeed;
    }
}

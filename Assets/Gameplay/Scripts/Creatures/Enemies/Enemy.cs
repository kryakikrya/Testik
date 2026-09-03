using UnityEngine;
using VContainer;

public class Enemy : Creature
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _minSpeed = 1;
    [SerializeField] private float _maxSpeed = 3;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private int _stopDistance;

    [Inject] private Player _player;

    private float _trueSpeed;

    private EnemyMovement _movement;

    private void Awake()
    {
        _trueSpeed = Random.Range(_minSpeed, _maxSpeed);

        _movement = new EnemyMovement(_player.transform, transform, _rb, _stopDistance);
    }

    private void FixedUpdate()
    {
        _movement.Move(_jumpForce, _trueSpeed);
    }
}

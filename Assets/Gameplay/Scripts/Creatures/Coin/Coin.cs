using UnityEngine;
using VContainer;

public class Coin : Creature
{
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private Rigidbody2D _rb;

    [Inject] private ScoreSystem _score;

    private CoinMovement _movement;

    private void Awake()
    {
        _movement = new CoinMovement(_rb);
    }

    private void FixedUpdate()
    {
        _movement.Move(_horizontalSpeed);
    }

    public void AddMoney()
    {
        _score.AddScore();
    }
}

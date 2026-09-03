using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;

public class Player : Creature
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rb;

    [Inject] private PlayerInput _input;

    private PlayerMovement _movement;

    private void Awake()
    {
        _movement = new PlayerMovement(_input, _rb);
    }

    private void FixedUpdate()
    {
        _movement.Move(_jumpForce);
    }

    public override void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

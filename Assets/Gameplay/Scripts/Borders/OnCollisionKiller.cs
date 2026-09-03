using UnityEngine;

public class OnCollisionKiller : MonoBehaviour
{
    [SerializeField] private LayerMask _layers;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((_layers.value & (1 << collision.gameObject.layer)) != 0)
        {
            if (collision.gameObject.TryGetComponent(out Creature creature))
            {
                creature.Death();
            }
        }
    }
}
using UnityEngine;

public class CoinKiller : OnCollisionKiller
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((_layers.value & (1 << collision.gameObject.layer)) != 0)
        {
            if (collision.gameObject.TryGetComponent(out Coin coin))
            {
                coin.AddMoney();
                coin.Death();
            }
        }
    }
}
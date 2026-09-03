using UnityEngine;
using VContainer.Unity;

public class CoinFactory : Factory<Coin>
{
    private Coin _prefab;

    public CoinFactory(Coin prefab)
    {
        _prefab = prefab;
    }

    protected override Coin CreateTyped(Vector3 position)
    {
        return _resolver.Instantiate<Coin>(_prefab, position, Quaternion.identity);
    }
}
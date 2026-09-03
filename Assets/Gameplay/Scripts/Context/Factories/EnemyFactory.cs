using UnityEngine;
using VContainer;
using VContainer.Unity;

public class EnemyFactory : Factory<Enemy>
{
    private Enemy _prefab;

    public EnemyFactory(Enemy prefab)
    {
        _prefab = prefab;
    }

    protected override Enemy CreateTyped(Vector3 position)
    {
        return _resolver.Instantiate<Enemy>(_prefab, position, Quaternion.identity);
    }
}

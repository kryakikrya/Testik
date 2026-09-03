using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class FactoriesLifetimeScope : LifetimeScope
{
    [Header("Enemy Factory")]
    [SerializeField] private CreatureFactorySO _enemyFactorySO;

    [Header("Coin Factory")]
    [SerializeField] private CreatureFactorySO _coinFactorySO;

    private List<(IFactory, float)> _factories = new List<(IFactory, float)>();

    protected override void Configure(IContainerBuilder builder)
    {
        ConfigureFactories();

        builder.RegisterInstance<List<(IFactory, float)>>(_factories);
    }

    private void ConfigureFactories()
    {
        if (_enemyFactorySO.GameObject.TryGetComponent(out Enemy enemy))
        {
            _factories.Add((new EnemyFactory(enemy), _enemyFactorySO.Cooldown));
        }
        else
        {
            Debug.LogError("Type missmatch");
        }

        if (_coinFactorySO.GameObject.TryGetComponent(out Coin coin))
        {
            _factories.Add((new CoinFactory(coin), _coinFactorySO.Cooldown));
        }
        else
        {
            Debug.LogError("Type missmatch");
        }
    }
}

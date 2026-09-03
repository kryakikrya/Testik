using VContainer;
using VContainer.Unity;
using UnityEngine;

public class GameEntryLifetimeScope : LifetimeScope
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerData _playerData;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(_playerData);

        builder.Register<PlayerInput>(Lifetime.Scoped);
        builder.Register<ScoreSystem>(Lifetime.Scoped);

        builder.RegisterInstance(_player);
    }
}

using VContainer;
using VContainer.Unity;
using UnityEngine;

public class GameEntryLifetimeScope : LifetimeScope
{
    [SerializeField] private Player _player;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<PlayerInput>(Lifetime.Scoped);
        builder.Register<ScoreSystem>(Lifetime.Scoped);

        builder.RegisterInstance(_player);
    }
}

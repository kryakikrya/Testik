using VContainer;
using VContainer.Unity;
using UnityEngine;
using UnityEngine.UIElements;
using Unity.Properties;

public class GameEntryLifetimeScope : LifetimeScope
{
    [SerializeField] private Player _player;
    [SerializeField] private UIDocument _uiDocument;

    protected override void Configure(IContainerBuilder builder)
    {
        ScorePlayerData playerData = new ScorePlayerData();

        var label = _uiDocument.rootVisualElement.Q<Label>("ScoreValue");

        label.SetBinding("text", new DataBinding
        {
            dataSource = playerData,
            dataSourcePath = new PropertyPath(nameof(ScorePlayerData.Score)),
            bindingMode = BindingMode.ToTarget
        });

        builder.RegisterInstance(playerData);
        builder.RegisterInstance(_uiDocument);

        builder.Register<PlayerInput>(Lifetime.Scoped);
        builder.Register<ScoreSystem>(Lifetime.Scoped);

        builder.RegisterInstance(_player);
    }
}

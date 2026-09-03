using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using VContainer;

public class ScoreUI : MonoBehaviour
{
    [Inject] private UIDocument _uiDocument;

    [Inject] private ScoreSystem _scoreSystem;

    private Label _scoreValue;

    private void Awake()
    {
        _scoreSystem.OnChanged += ChangeUI;

        _scoreValue = _uiDocument.rootVisualElement.Q<Label>("ScoreValue");
    }

    private void ChangeUI(int score)
    {
        _scoreValue.text = score.ToString();
    }

    private void OnDestroy()
    {
        _scoreSystem.OnChanged -= ChangeUI;
    }
}

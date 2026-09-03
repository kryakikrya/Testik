using System;

public class ScoreSystem
{
    private int _score = 0;

    public Action<int> OnChanged;

    public int Score => _score;

    public void AddScore()
    {
        _score++;

        OnChanged?.Invoke(_score);
    }
}

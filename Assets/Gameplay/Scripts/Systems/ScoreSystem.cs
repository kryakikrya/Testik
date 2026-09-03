using UnityEngine;

public class ScoreSystem
{
    private ScorePlayerData _playerData;

    private int _score = 0;

    public ScoreSystem(ScorePlayerData data)
    {
        data.Score = 0;
        _playerData = data;
        AddScore();
    }

    public void AddScore()
    {
        _score++;

        _playerData.Score = _score;
    }
}

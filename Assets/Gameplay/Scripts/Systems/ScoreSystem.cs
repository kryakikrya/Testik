using VContainer;

public class ScoreSystem
{
    private PlayerData _playerData;

    private int _score = 0;

    public ScoreSystem(PlayerData data)
    {
        data.Score = 0;

        _playerData = data;
    }

    public void AddScore()
    {
        _score++;

        _playerData.Score = _score;
    }
}

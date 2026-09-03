using UnityEngine;
using Unity.Properties;

[CreateAssetMenu(menuName = "Game/PlayerData")]
public class PlayerData : ScriptableObject
{
    [CreateProperty] public int Score = 0;
}
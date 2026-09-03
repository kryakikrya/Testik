using UnityEngine;

[CreateAssetMenu(fileName = "CreatureFactorySO", menuName = "Scriptable Objects/CreatureFactorySO")]
public class CreatureFactorySO : ScriptableObject
{
    public GameObject GameObject;
    public float Cooldown;
}
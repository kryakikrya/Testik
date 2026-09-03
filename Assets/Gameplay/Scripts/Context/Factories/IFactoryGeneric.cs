using UnityEngine;

public interface IFactory<out T> : IFactory
{
    public new T Create(Vector3 position);
}

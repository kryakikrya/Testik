using UnityEngine;
using VContainer;

public abstract class Factory<T> : IFactory<T> where T : Creature
{
    protected IObjectResolver _resolver;

    public T Create(Vector3 position)
    {
        return CreateTyped(position);
    }

    object IFactory.Create(Vector3 position)
    {
        return CreateTyped(position);
    }

    public void SetResolver(IObjectResolver resolver)
    {
        _resolver = resolver;
    }

    protected abstract T CreateTyped(Vector3 position);
}
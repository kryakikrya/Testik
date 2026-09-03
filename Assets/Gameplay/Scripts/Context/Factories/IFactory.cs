using UnityEngine;
using VContainer;

public interface IFactory
{
    public object Create(Vector3 position);

    public void SetResolver(IObjectResolver resolver);
}

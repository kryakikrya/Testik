using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;

public class SpawningSystem : MonoBehaviour
{
    [SerializeField] private Vector3 _spawnPositionTop;
    [SerializeField] private Vector3 _spawnPositionBottom;

    [Inject] private List<(IFactory, float)> _factory;
    [Inject] private IObjectResolver _objectResolver;

    private void Awake()
    {
        foreach (var factory in _factory)
        {
            factory.Item1.SetResolver(_objectResolver);
            StartCoroutine(Spawn(factory.Item1, factory.Item2));
        }
    }

    public IEnumerator Spawn(IFactory factory, float timer)
    {
        while (true)
        {
            factory.Create(new Vector2(UnityEngine.Random.Range(_spawnPositionBottom.x, _spawnPositionTop.x), UnityEngine.Random.Range(_spawnPositionBottom.y, _spawnPositionTop.y)));
            yield return new WaitForSeconds(timer);
        }
    }
}

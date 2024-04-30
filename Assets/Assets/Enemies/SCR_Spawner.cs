using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Spawner : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Time between each box spawns")]
    private float _timeBetweenSpawns;

    private float _currentTime;

    [SerializeField]
    [Tooltip("Prefab to instantiate")]
    SCR_Spawnable _prefabSpawn;

    [SerializeField]
    [Tooltip("Range to spawn objects")]
    private float _minX, _maxX, _minY, _maxY;

    private void Start()
    {
        _currentTime = _timeBetweenSpawns;
    }

    void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        _currentTime -= Time.deltaTime;

        if (_currentTime <= 0)
        {
            SpawnBox();
            _currentTime = _timeBetweenSpawns;
        }
    }

    private void SpawnBox()
    {
        GameObject.Instantiate(_prefabSpawn, new Vector2(Random.Range(_minX, _maxX), Random.Range(_minY, _maxY)), Quaternion.identity);
    }
}
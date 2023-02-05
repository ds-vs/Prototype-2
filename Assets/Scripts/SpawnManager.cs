using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _animalPrefab;

    private Vector3 _spawnPoint;

    private Vector3 _rotation;

    private int _animalIndex;
    
    private float _spawnRangeX = 25.0f;
    private float _spawnRangeZ = 15.0f;

    private float _agrSpawnRangeX = 13.0f;
    private float _agrSpawnRangeZ = 30.0f;

    private float _startDelay = 2.0f;
    private float _spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnAgrAnimals", _startDelay, _spawnInterval);

        InvokeRepeating("SpawnRightAnimals", _startDelay, _spawnInterval);

        InvokeRepeating("SpawnLeftAnimals", _startDelay, _spawnInterval);
    }

    private void SpawnAgrAnimals()
    {
        _spawnPoint = new Vector3(Random.Range(-_agrSpawnRangeX, _agrSpawnRangeX), 0, _agrSpawnRangeZ);

        Instantiate(_animalPrefab[0], _spawnPoint, _animalPrefab[0].transform.rotation);
    }

    private void SpawnRightAnimals()
    {
        _animalIndex = Random.Range(1, _animalPrefab.Length);

        _rotation = new Vector3(0, -90, 0);

        _spawnPoint = new Vector3(_spawnRangeX, 0, Random.Range(-_spawnRangeZ + 18.0f, _spawnRangeZ));

        Instantiate(_animalPrefab[_animalIndex], _spawnPoint, Quaternion.Euler(_rotation));
    }
    
    private void SpawnLeftAnimals()
    {
        _animalIndex = Random.Range(1, _animalPrefab.Length);

        _rotation = new Vector3(0, 90, 0);

        _spawnPoint = new Vector3(-_spawnRangeX, 0, Random.Range(-_spawnRangeZ + 18.0f, _spawnRangeZ));

        Instantiate(_animalPrefab[_animalIndex], _spawnPoint, Quaternion.Euler(_rotation));
    }
}

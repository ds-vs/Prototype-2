using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _animalPrefab;

    [SerializeField] private KeyCode _key;

    private Vector3 _spawnPoint;
    
    private int _animalIndex;
    private float _spawnRangeX = 14.0f;
    private float _spawnRangeZ = 34.0f;

    void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            _animalIndex = Random.Range(0, _animalPrefab.Length);

            _spawnPoint = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnRangeZ);
            
            Instantiate(_animalPrefab[_animalIndex], _spawnPoint,
                _animalPrefab[_animalIndex].transform.rotation);
        }
    }
}

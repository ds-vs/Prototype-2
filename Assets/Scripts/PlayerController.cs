using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject[] _projectilePrefab;
    [SerializeField] private KeyCode _key;

    [SerializeField] private float _speed = 25.0f;

    private int _projectileIndex;

    private float xRange = 15.0f;
    private float _horizontalInput;

    public void CheckPlayerPostiton()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    void Update()
    {
        CheckPlayerPostiton();

        _horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * _speed * _horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(_key))
        {
            _projectileIndex = Random.Range(0, _projectilePrefab.Length);

            // Создаю копии объектов
            Instantiate(_projectilePrefab[_projectileIndex], transform.position,
                _projectilePrefab[_projectileIndex].transform.rotation);
        }
    }
}

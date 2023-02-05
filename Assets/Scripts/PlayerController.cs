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

    private float _xRange = 15.0f;
    private float _zRangeUp = 13.5f;
    private float _zRangeDown = -1.0f;

    private float _horizontalInput;
    private float _verticalInput;

    private void CheckPlayerPostiton()
    {
        if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z > _zRangeUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, _zRangeUp);
        }
        if (transform.position.z < _zRangeDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, _zRangeDown);
        }
    }

    private void Update()
    {
        CheckPlayerPostiton();

        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * _speed * _horizontalInput * Time.deltaTime);

        transform.Translate(Vector3.forward * _speed * _verticalInput * Time.deltaTime);

        if (Input.GetKeyDown(_key))
        {
            _projectileIndex = Random.Range(0, _projectilePrefab.Length);

            // Создаю копии объектов
            Instantiate(_projectilePrefab[_projectileIndex], transform.position,
                _projectilePrefab[_projectileIndex].transform.rotation);
        }
    }
}
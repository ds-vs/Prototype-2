using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 25.0f;
    [SerializeField] private float _xRange = -10.0f;

    private float _horizontalInput;

    public void CheckPlayerPostiton()
    {
        if (transform.position.x < _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }
    }

    void Update()
    {
        CheckPlayerPostiton();

        _horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * _speed * _horizontalInput * Time.deltaTime);
    }
}

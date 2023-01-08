using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _speed = 25.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}

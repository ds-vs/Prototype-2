using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _zTopBound = 35.0f;
    private float _zLowerBound = -15.0f;

    private float _xBound = 30.0f;

    private void Update()
    {
        if (transform.position.z > _zTopBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < _zLowerBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > _xBound || transform.position.x < -_xBound)
        {
            Destroy(gameObject);
        }
    }
}

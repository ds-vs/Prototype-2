using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30.0f;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float timer = 0.0f;
    private float spawnTime = 3.0f;

    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        Debug.Log(timer);

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = spawnTime;
        }
    }
}

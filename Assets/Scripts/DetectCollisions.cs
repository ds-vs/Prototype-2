using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameController _player;

    private void Start()
    {
        _player = GameObject.Find("GameManager").GetComponent<GameController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _player.SetHealth(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            _player.SetScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

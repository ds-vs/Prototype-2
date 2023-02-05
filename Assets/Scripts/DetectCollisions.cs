using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    private GameController _player;

    private float _hungerLevel = 0f;
    private float _maxHungerLevel = 90.0f;

    [SerializeField] private Image _scale;

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
            Destroy(other.gameObject);
            _hungerLevel += 30.0f;
            _scale.fillAmount = _hungerLevel / _maxHungerLevel;

            if (_hungerLevel == _maxHungerLevel)
            {
                _player.SetScore(1);
                Destroy(gameObject);
            }
        }
    }
}

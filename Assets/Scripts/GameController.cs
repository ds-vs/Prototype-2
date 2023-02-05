using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private int _health = 5;

    private int _score = 0;

    public void SetHealth(int value)
    {
        if (_health > 1)
        {
            _health += value;
            Debug.Log($"{_health} hp");
        }
        else
        {
            Debug.Log("Вы умерли!");
        }
    }

    public void SetScore(int value)
    {
        if (_score < 25)
        {
            _score += value;
            Debug.Log($"Score: {_score}");
        }
        else
        {
            Debug.Log("Вы победили!");
        }
    }
}

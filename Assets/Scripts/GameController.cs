using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreUI;
    [SerializeField] private TextMeshProUGUI _healthUI;

    [SerializeField] private int _health = 2;

    private int _score = 0;

    private void Start()
    {
        _healthUI.text = $"Hp: {_health}";
    }

    public void SetHealth(int value)
    {
        if (_health > 1)
        {
            _health += value;
            _healthUI.text = $"Hp: {_health}";
        }
        else
        {
            _health = 0;
            _healthUI.text = $"Hp: {_health}";

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Вы умерли!");
        }
    }

    public void SetScore(int value)
    {
        _score += value;
        _scoreUI.text = $"Score: {_score}";

        if (_score == 24)
        {
            Debug.Log("Вы победили!");
        }
    }
}

using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoseGameWindow : MonoBehaviour
{
    public static event Action OnLoseGameButtonClicked;

    [SerializeField] private TextMeshProUGUI _newGameText;

    [SerializeField] private TextMeshProUGUI _scoreText;

    [SerializeField] private Button _loseGameButton;

    private void Awake()
    {
        _loseGameButton.onClick.AddListener(StartNewGame);
    }

    public void ShowScore(int score)
    {
        _scoreText.text = $"Количество очков: {score}";
    }

    private void StartNewGame()
    {
        OnLoseGameButtonClicked?.Invoke();
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        _loseGameButton.onClick.RemoveListener(StartNewGame);
    }
}
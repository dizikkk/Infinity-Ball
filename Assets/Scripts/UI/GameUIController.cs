using UnityEngine;
using TMPro;

public class GameUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    [SerializeField] private TextMeshProUGUI _healthText;

    [SerializeField] private StartGameWndow _startGameWindow;

    [SerializeField] private LoseGameWindow _loseGameWindow;

    private void Awake()
    {
        PlayerBall.OnScoreChanged += ShowScore;
        PlayerBall.OnHealthChanged += ShowHealth;
        PlayerBall.OnDeath += ShowLoseGameWindow;
    }

    private void ShowLoseGameWindow()
    {
        _loseGameWindow.gameObject.SetActive(true);
    }

    private void ShowHealth(float health)
    {
        _healthText.text = $"Health: {health}";
    }

    private void ShowScore(int score)
    {
        _scoreText.text = $"Score: {score}";
    }

    private void OnDestroy()
    {
        PlayerBall.OnScoreChanged -= ShowScore;
        PlayerBall.OnHealthChanged -= ShowHealth;
        PlayerBall.OnDeath -= ShowLoseGameWindow;
    }
}
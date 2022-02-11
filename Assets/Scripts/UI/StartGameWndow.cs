using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartGameWndow : MonoBehaviour
{
    public static event Action OnStartGameButtonClicked;

    [SerializeField] private TextMeshProUGUI _newGameText;

    [SerializeField] private Button _startGameButton;

    private void Awake()
    {
        _startGameButton.onClick.AddListener(StartNewGame);
    }

    private void StartNewGame()
    {
        OnStartGameButtonClicked?.Invoke();
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        _startGameButton.onClick.RemoveListener(StartNewGame);
    }
}
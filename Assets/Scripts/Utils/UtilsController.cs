using UnityEngine;

public class UtilsController : MonoBehaviour
{
    private PauseGameController _pauseGameController;

    private SceneController _sceneController;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        _pauseGameController = new PauseGameController();
        _sceneController = new SceneController();

        StartGameWndow.OnStartGameButtonClicked += UnpauseGame;
        LoseGameWindow.OnLoseGameButtonClicked += ReloadScene;

        PlayerBall.OnDeath += PauseGame;
    }

    private void Start()
    {
        PauseGame();
    }

    private void UnpauseGame()
    {
        _pauseGameController.UnpauseGame();
    }

    private void PauseGame()
    {
        _pauseGameController.PauseGame();
    }

    private void ReloadScene()
    {
        _sceneController.ReloadScene();
    }
}
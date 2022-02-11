using UnityEngine;

public abstract class BallController : MonoBehaviour
{
    private IBall _ball;

    public void Init(IBall ball)
    {
        _ball = ball;
    }

    private void Update()
    {
        ProcessHandling(_ball.BallMovement);
    }

    protected abstract void ProcessHandling(BallMovement movementSystem);
}
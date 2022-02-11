using UnityEngine;

public class Ball : MonoBehaviour, IBall
{
    [SerializeField] private BallController _ballController;

    [SerializeField] private BallMovement _ballMovement;

    public BallMovement BallMovement => _ballMovement;

    private void Start()
    {
        _ballController.Init(this);
    }
}
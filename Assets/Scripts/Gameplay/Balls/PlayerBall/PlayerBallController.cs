using UnityEngine;

public class PlayerBallController : BallController
{
    private DirectionMovementType _directionMovementType = DirectionMovementType.Left;

    protected override void ProcessHandling(BallMovement movementSystem)
    {
        movementSystem.UpperMovement(Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            if (_directionMovementType == DirectionMovementType.Left)
                _directionMovementType = DirectionMovementType.Right;
            else
                _directionMovementType = DirectionMovementType.Left;
        }

        movementSystem.HorizontalMovement(Time.deltaTime, _directionMovementType);
    }
}
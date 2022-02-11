using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float _horizontalMovementSpeed;

    [SerializeField] private float _upperMovementSpeed;

    public float HorizontalMovementSpeed { get => _horizontalMovementSpeed; set => _horizontalMovementSpeed = value; }
    public float UpperMovementSpeed { get => _upperMovementSpeed; set => _upperMovementSpeed = value; }

    public void HorizontalMovement(float amount, DirectionMovementType direction)
    {
        switch (direction)
        {
            case DirectionMovementType.Left:
                Move(amount * _horizontalMovementSpeed, -Vector3.right);
                break;
            case DirectionMovementType.Right:
                Move(amount * _horizontalMovementSpeed, Vector3.right);
                break;
        }
    }

    public void UpperMovement(float amount)
    {
        Move(amount * _upperMovementSpeed, Vector3.up);
    }

    private void Move(float amount, Vector3 axis)
    {
        transform.Translate(amount * axis.normalized);
    }
}
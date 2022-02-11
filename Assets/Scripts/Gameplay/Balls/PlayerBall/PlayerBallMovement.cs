using System.Collections;
using UnityEngine;

public class PlayerBallMovement : BallMovement
{
    private float _startUpperMovementSpeed;

    private void Awake()
    {
        PlayerBall.OnScoreChanged += ChangeMovementSpeedByScore;
        _startUpperMovementSpeed = UpperMovementSpeed;
    }

    private void ChangeMovementSpeedByScore(int score)
    {
        if (score == 10)
        {
            StartCoroutine(CalculateSpeed(_startUpperMovementSpeed * 1.5f, 2f));
        }

        if (score == 25)
        {
            StartCoroutine(CalculateSpeed(_startUpperMovementSpeed * 2f, 2f));
        }

        if (score == 50)
        {
            StartCoroutine(CalculateSpeed(_startUpperMovementSpeed * 3f, 2f));
        }

        if (score == 100)
        {
            StartCoroutine(CalculateSpeed(_startUpperMovementSpeed * 4f, 2f));
        }
    }

    private IEnumerator CalculateSpeed(float neededSpeedValue, float duration)
    {
        float tickValue = 0.1f;

        float intervalValue = (neededSpeedValue / duration) * tickValue;

        while (UpperMovementSpeed <= neededSpeedValue)
        {
            UpperMovementSpeed += intervalValue;
            yield return new WaitForSeconds(tickValue);
        }
    }
}
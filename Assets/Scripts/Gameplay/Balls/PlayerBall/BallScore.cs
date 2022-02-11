using UnityEngine;

public class BallScore : MonoBehaviour
{
    [SerializeField] private int _score;

    public int Score => _score;

    public void AddingScore(int score)
    {
        _score += score;
    }
}
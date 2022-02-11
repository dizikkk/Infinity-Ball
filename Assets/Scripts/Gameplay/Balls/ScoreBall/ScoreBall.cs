using UnityEngine;

public class ScoreBall : Ball
{
    [SerializeField] private int _score;

    private void OnCollisionEnter(Collision other)
    {
        var scorableObject = other.gameObject.GetComponent<IScorable>();

        if (scorableObject != null)
        {
            scorableObject.ApplyScore(_score);
            Destroy(gameObject);
        }
    }
}
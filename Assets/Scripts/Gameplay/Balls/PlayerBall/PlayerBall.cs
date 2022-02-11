using System;
using UnityEngine;

public class PlayerBall : Ball, IDamagable, IScorable
{
    public static event Action<float> OnHealthChanged;

    public static event Action<int> OnScoreChanged;

    public static event Action OnDeath;

    [SerializeField] private BallHealth _ballHealth;

    [SerializeField] private BallScore _ballScore;

    public void ApplyDamage(IDamageDealer damageDealer)
    {
        _ballHealth.ReduceHealth(damageDealer.Damage);
        OnHealthChanged?.Invoke(_ballHealth.GetCurrentHealth());

        if (_ballHealth.GetCurrentHealth() <= 0)
            OnDeath?.Invoke();
    }

    public void ApplyScore(int score)
    {
        _ballScore.AddingScore(score);
        OnScoreChanged?.Invoke(_ballScore.Score);
    }
}
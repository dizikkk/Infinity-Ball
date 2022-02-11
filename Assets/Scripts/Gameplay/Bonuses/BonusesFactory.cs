using UnityEngine;

public class BonusesFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T _bonusPrefab;

    public T CreateBonus(Vector3 spawnPoint)
    {
        return Instantiate(_bonusPrefab, spawnPoint, Quaternion.identity);
    }
}
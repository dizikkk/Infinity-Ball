using UnityEngine;

public class DamageWall : MonoBehaviour, IDamageDealer
{
    [SerializeField] private float _damage;

    public float Damage => _damage;

    private void OnCollisionEnter(Collision other)
    {
        var damagableObject = other.gameObject.GetComponent<IDamagable>();

        if (damagableObject != null)
        {
            damagableObject.ApplyDamage(this);
        }
    }
}
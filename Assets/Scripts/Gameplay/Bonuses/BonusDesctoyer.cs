using UnityEngine;

public class BonusDesctoyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball _bonusBall = other.GetComponent<Ball>();

        if (_bonusBall != null)
            Destroy(_bonusBall.gameObject);
    }
}
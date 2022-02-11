using UnityEngine;

public class MovableWalls : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 22f, transform.position.z);
    }
}
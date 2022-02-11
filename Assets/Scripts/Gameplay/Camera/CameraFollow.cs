using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private PlayerBall _targetPlayerBall;
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private float _smoothTime;

    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        if (_targetPlayerBall != null)
        {
            _cameraTransform.position = 
                Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, _targetPlayerBall.transform.position.y, transform.position.z), ref velocity, _smoothTime);

        }
    }
}
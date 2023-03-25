using UnityEngine;

public sealed class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 _newPosition;

    private void LateUpdate()
    {
        if (_target != null)
        {
            if (_target.transform.position.y > transform.position.y)
            {
                _newPosition = new Vector3(transform.position.x, _target.transform.position.y, transform.position.z);
                transform.position = _newPosition;
            }
        }
    }
}

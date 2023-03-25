using UnityEngine;

public sealed class Destroying : MonoBehaviour
{
    private float _borderToRemove;

    private void Update()
    {
        _borderToRemove = Camera.main.transform.position.y - Camera.main.orthographicSize;

        if (transform.position.y < _borderToRemove)
        {
            Destroy(gameObject);
        }
    }
}

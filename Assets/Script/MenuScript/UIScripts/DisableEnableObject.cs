using UnityEngine;

public class DisableEnableObject : MonoBehaviour
{
    [SerializeField] private GameObject _object;

    public void DisableObject()
    {
        if (_object.activeInHierarchy)
            gameObject.SetActive(false);
    }

    public void EnableObject()
    {
        if (!_object.activeInHierarchy)
            gameObject.SetActive(true);
    }
}

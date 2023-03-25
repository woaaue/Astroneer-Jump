using UnityEngine;

public sealed class BorderHorizonal : MonoBehaviour
{
    private const float _borderX = 8.89f;

    private void Update()
    {
        Vector3 objectPosition = gameObject.transform.position;

        if (gameObject.transform.position.x > _borderX)
        {
            objectPosition.x = -_borderX;
            gameObject.transform.position = objectPosition;
        }
        if (gameObject.transform.position.x < -_borderX)
        {
            objectPosition.x = _borderX;
            gameObject.transform.position = objectPosition;
        } 
    }
}

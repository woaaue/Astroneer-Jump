using UnityEngine;

public sealed class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Rigidbody2D rigidbody))
        {
            int coins = PlayerPrefs.GetInt("coins");
            PlayerPrefs.SetInt("coins", coins + 1);
            Destroy(gameObject);
        }
    }
}

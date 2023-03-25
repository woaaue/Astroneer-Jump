using UnityEngine;

public sealed class CoinSelection : MonoBehaviour
{
    private AudioSource _coinSelectionEffect;

    private void Start()
    {
        _coinSelectionEffect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _coinSelectionEffect.Play();
    }
}

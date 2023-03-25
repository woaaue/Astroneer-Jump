using UnityEngine;

public sealed class Platform : MonoBehaviour
{
    [Range(0f, 5000f)]
    [SerializeField] private float _jumpForce;
    private AudioSource _audioEffect;

    private void Start()
    {
        _audioEffect = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Rigidbody2D rigidbody))
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                _audioEffect.Play();
                rigidbody.velocity = Vector2.up * _jumpForce * Time.deltaTime;
            }
        }
    }
}

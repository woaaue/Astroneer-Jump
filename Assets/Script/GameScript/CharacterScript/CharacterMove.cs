using UnityEngine;

public sealed class CharacterMove : MonoBehaviour, IMovable
{
    [Range(0f, 1000f)]
    [SerializeField] private float _speed;

    private float _movement;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        _movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        Vector2 velocity = _rigidbody.velocity;
        velocity.x = _movement * _speed * Time.fixedDeltaTime;
        _rigidbody.velocity = velocity;
    }
}

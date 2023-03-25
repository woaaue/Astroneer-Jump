using UnityEngine;

public sealed class LevelGenerator : CreateManager
{
    [SerializeField] private GameObject _defaultPlatform;
    [SerializeField] private GameObject _jumpPlatform;
    [SerializeField] private GameObject _coin;
    [SerializeField] private GameObject _character;

    private Vector3 _startingPosition;
    private Vector3 _newStartPosition;
    private int _counter;
    private float _rangeX;
    private float _rangeY;
    // -7.1, 7.1 координаты по х в которых можно создать обычную платформу
    // +4 граница по y 
    // 1.3 длина платформы по x суммарно = 2.6
    private void Start()
    {
        _startingPosition = transform.position;
    }

    [System.Obsolete]
    private void Update()
    {
        if (_character != null)
        {
            if (_startingPosition.y - _character.transform.position.y < 50f)
            {
                DeterminePosition();
                SetCoordinates();

                if (_counter <= 70)
                {
                    CreateObject(_defaultPlatform, _newStartPosition, Quaternion.identity);

                    if (_counter <= 10)
                    {
                        CreateObject(_coin, _newStartPosition + Vector3.up, Quaternion.identity);
                    }
                }
                else 
                {
                    CreateObject(_jumpPlatform, _newStartPosition, Quaternion.identity);
                }
            }
        }

        _startingPosition = _newStartPosition;
    }

    [System.Obsolete]
    private void DeterminePosition()
    {
        _counter = Random.RandomRange(0, 101);
        _rangeX = Random.RandomRange(-7.1f, 7.2f);
        _rangeY = Random.RandomRange(2f, 3.8f);
    }

    private void SetCoordinates()
    {
        _newStartPosition.x = _rangeX;
        _newStartPosition.y = _startingPosition.y + _rangeY;
        _newStartPosition.z = _startingPosition.z;
    }
}

using UnityEngine;
using TMPro;

public sealed class Score : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private TextMeshProUGUI _scoreCount;

    private float _currentlyPostionY;
    private float _maxPostionY;

    private void Update()
    {
        if (_target != null)
        {
            _currentlyPostionY = _target.position.y;

            if (_currentlyPostionY > _maxPostionY)
            {
                _maxPostionY = _currentlyPostionY;

                int _scoreMultiplier = (int)((Mathf.Pow(_maxPostionY, 3) / Mathf.Sqrt(_maxPostionY * _maxPostionY)) / 4);  

                _scoreCount.text = _scoreMultiplier.ToString();
            }
        }
    }
}

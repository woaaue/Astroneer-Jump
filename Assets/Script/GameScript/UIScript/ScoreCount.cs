using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] private GameObject _character;
    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _resultScore;
    [SerializeField] private TextMeshProUGUI _bestScore;

    private int _recordScore;

    private void Awake()
    {
        _recordScore = PlayerPrefs.GetInt("score");
    }

    private void Update()
    {
        if (_character == null)
            CountScore();
    }

    private void CountScore()
    {
        if (int.TryParse(_currentScore.text, out int digit))
        {
            if (digit > _recordScore)
            {
                PlayerPrefs.SetInt("score", digit);
                _bestScore.text = digit.ToString();
            }
            else
            {
                _bestScore.text = _recordScore.ToString();
            }
        }
        
        _resultScore.text = _currentScore.text;
    }
}

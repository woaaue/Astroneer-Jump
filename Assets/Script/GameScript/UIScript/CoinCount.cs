using UnityEngine;
using TMPro;

public class CoinCount : MonoBehaviour
{
    private TextMeshProUGUI _coinCount;

    private void Awake()
    {
        _coinCount = GetComponent<TextMeshProUGUI>();
        _coinCount.text = PlayerPrefs.GetInt("coins").ToString();
    }

    private void LateUpdate()
    {
        _coinCount.text = PlayerPrefs.GetInt("coins").ToString();
    }
}

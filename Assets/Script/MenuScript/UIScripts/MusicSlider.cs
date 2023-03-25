using UnityEngine.UI;
using UnityEngine;

public sealed class MusicSlider : MonoBehaviour
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.value = PlayerPrefs.GetFloat("sliderMusicValue", 1);
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("sliderMusicValue", _slider.value);
    }
}

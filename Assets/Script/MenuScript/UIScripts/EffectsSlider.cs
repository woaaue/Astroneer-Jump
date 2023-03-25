using UnityEngine.UI;
using UnityEngine;

public sealed class EffectsSlider : MonoBehaviour
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.value = PlayerPrefs.GetFloat("sliderEffectsValue", 1);
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("sliderEffectsValue", _slider.value);
    }
}

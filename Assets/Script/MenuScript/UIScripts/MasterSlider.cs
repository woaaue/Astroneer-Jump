using UnityEngine.UI;
using UnityEngine;

public sealed class MasterSlider : MonoBehaviour
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.value = PlayerPrefs.GetFloat("sliderMasterValue", 1);
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("sliderMasterValue", _slider.value);
    }
}

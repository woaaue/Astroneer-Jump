using UnityEngine.Audio;
using UnityEngine;

public sealed class Audio : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    public void EditMasterVolume(float value)
    {
        _mixer.audioMixer.SetFloat("MasterVolume", value);

        PlayerPrefs.SetFloat("mixerMasterVolume", value);
    }

    public void EditMusicVolume(float value)
    {
        _mixer.audioMixer.SetFloat("MusicVolume", value);

        PlayerPrefs.SetFloat("mixerMusicVolume", value);
    }

    public void EditEffectsVolume(float value)
    {
        _mixer.audioMixer.SetFloat("EffectsVolume", value);

        PlayerPrefs.SetFloat("mixerEffectsVolume", value);
    }
}

using UnityEngine.Audio;
using UnityEngine;

public sealed class Volume : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    private float _volumeMaster;
    private float _volumeMusic;
    private float _volumeEffects;

    private void Start()
    {
        _volumeMaster = PlayerPrefs.GetFloat("mixerMasterVolume");
        _volumeMusic = PlayerPrefs.GetFloat("mixerMusicVolume");
        _volumeEffects = PlayerPrefs.GetFloat("mixerEffectsVolume");

        _mixer.audioMixer.SetFloat("MasterVolume", _volumeMaster);
        _mixer.audioMixer.SetFloat("MusicVolume", _volumeMusic);
        _mixer.audioMixer.SetFloat("EffectsVolume", _volumeEffects);
    }
}

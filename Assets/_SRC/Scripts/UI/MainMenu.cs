using com.TosomaTomaya.core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixerEffectPlugin audioMixer;
    public Slider UISliderMusicVolumen;


    private void Awake()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = Resources.Load(Constants.RESOURCES.MUSIC_FOLDER + "MenuTheme") as AudioClip;
        audio.loop = enabled;
        audio.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        GameData.instance.Init();

        UISliderMusicVolumen.onValueChanged.AddListener(
            (float volume) => {
                GameData.instance.musicVolume = volume;
            }
        );
    }

    
}

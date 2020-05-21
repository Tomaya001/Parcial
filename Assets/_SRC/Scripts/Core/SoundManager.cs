﻿using com.TosomaTomaya.core.config;
using com.TosomaTomaya.core;
using com.TosomaTomaya.core.storage;
using com.TosomaTomaya.core.util;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager 
{
    public static GameObject AddMusic(string music,string mixer) {

        

        if (Util.isEmpty(music)) return null;
        
        GameObject go = GameObject.Find(music);
        if(go == null) {
            go = new GameObject();
            go.name = music;                
        }

        AudioClip audioClip = AssetLoader.GetAsset<AudioClip>(music);
        if (audioClip != null) {
            AudioSource audioSource = go.GetComponent<AudioSource>();
            if (audioSource == null) {
                audioSource = go.AddComponent<AudioSource>();
            }

            // get audiomixer and assign sound / master
            AudioMixer am = GameData.instance.musicMixer;                            
            audioSource.outputAudioMixerGroup = am.FindMatchingGroups("Master")[0];
            audioSource.clip = audioClip;
            audioSource.loop = true;
            audioSource.Play();

            // setup volume
            //float volume = Storage.GetFloat(Const.STORAGE.KEY_MUSIC_VOLUME, Config.instance.sound.defaultMusicVolume);
            //am.SetFloat(Const.AUDIO_MIXER.MUSIC_VOLUME, GameData.insta);

        }

        return go;

    }
}

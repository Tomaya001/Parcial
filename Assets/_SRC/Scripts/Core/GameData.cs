using com.TosomaTomaya.core.config;
using com.TosomaTomaya.core.storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using static com.TosomaTomaya.core.config.Config;

namespace com.TosomaTomaya.core {


    public class GameData {

        public static GameData _instance;
        public static GameData instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameData();

                return _instance;
            }
        }
        private AudioMixer _musicMixer;
        public AudioMixer musicMixer
        {
            get
            {

                return _musicMixer;
            }
        }
        public float musicVolume
        {
            get
            {
                return Storage.GetFloat(Constants.STORAGE.KEY_MUSIC_VOLUME, Config.instance.sound.defaultMusicVolume);
            }
            set
            {
                _musicMixer.SetFloat(Constants.AUDIO_MIXER.MUSIC_VOLUME, value);
                Storage.SaveFloat(Constants.STORAGE.KEY_MUSIC_VOLUME, value);

            }
        }

        private AudioMixer _fxMixer;
        public AudioMixer fxMixer
        {
            get
            {
                return _fxMixer;
            }
        }
        public float fxVolume
        {
            get
            {
                return Storage.GetFloat(Constants.STORAGE.KEY_FX_VOLUME, Config.instance.sound.defaultFxVolume);
            }
            set
            {
                _fxMixer.SetFloat(Constants.AUDIO_MIXER.FX_VOLUME, value);
                Storage.SaveFloat(Constants.STORAGE.KEY_FX_VOLUME, value);
            }
        }

        public void Init() {

            _musicMixer = AssetLoader.GetAsset<AudioMixer>(Constants.RESOURCES.MUSIC_AUDIO_MIXER);
            _musicMixer.SetFloat(Constants.AUDIO_MIXER.MUSIC_VOLUME, musicVolume);

            _fxMixer = AssetLoader.GetAsset<AudioMixer>(Constants.RESOURCES.FX_AUDIO_MIXER);
            _fxMixer.SetFloat(Constants.AUDIO_MIXER.FX_VOLUME, fxVolume);
        }

    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.TosomaTomaya.core
{
    public class Constants
    {
        public static class LAYERS
        {
            public static int PLAYER = 8;
            public static int ENEMY = 9;
            public static int ENTORNO = 10;
            public static int TARGET = 30;
            public static int TEST = 31;
        }

        public static class PREFAB
        {
            public static string FIREBALL = "Prefab/Fireball";
            public static string PORTALS = "Prefab/Portal";
        }

        public static class RESOURCES
        {
            public static string CONFIG_FILE = "Config/config";
            public static string MUSIC_FOLDER = "Music/";
            public static string MUSIC_AUDIO_MIXER = "Sound/Music";
            public static string FX_AUDIO_MIXER = "Sound/FX";

        }

        public static class STORAGE
        {
            public static string KEY_LANG = "lang";
            public static string KEY_MUSIC_VOLUME = "music_volume";
            public static string KEY_FX_VOLUME = "fx_volume";
            public static string KEY_DIFFICULTY = "difficulty";
        }

        public static class SCENES
        {
            public static string MAIN = "MenuScene";
            public static string GAMEPLAY = "GamePlayScene";
        }

        public static class TAG
        {
            public static string MAIN = "Main";
            public static string PORTAL = "Portal";
        }

        public static class AUDIO_MIXER
        {            public static string MUSIC_VOLUME = "musicVolume";
            public static string FX_VOLUME = "fxVolume";
        }
    }
}


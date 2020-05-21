﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.TosomaTomaya.core.storage {


    public class Storage {
        
        // Start is called before the first frame update
        public static void SaveString(string key, string value) {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }
        
        public static string GetString(string key,string defaultValue) {
            return PlayerPrefs.GetString(key,defaultValue);
        }

        public static void SaveFloat(string key, float value) {
            PlayerPrefs.SetFloat(key, value);
            PlayerPrefs.Save();
        }

        public static float GetFloat(string key, float defaultValue) {
            return PlayerPrefs.GetFloat(key, defaultValue);
        }

    }


}

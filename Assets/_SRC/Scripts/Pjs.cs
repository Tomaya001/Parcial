using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace com.TosomaTomaya.pjs
{
    public class Pjs
    {
        private static Dictionary<string,Dictionary<string,int>> personajes;

        public static void init()
        {
            TextAsset pjs = Resources.Load<TextAsset>("Personajes/pjs");

            PjList pjsList = JsonUtility.FromJson<PjList>(pjs.text);


            personajes = new Dictionary<string, Dictionary<string, int>>();

            foreach (PjsRef p in pjsList.pjs)
            {
                Dictionary<string, int> stats = new Dictionary<string, int>();

                //personajes.Add(p.stat, p.value);
            }
            Debug.Log(personajes);
        }

    }
}


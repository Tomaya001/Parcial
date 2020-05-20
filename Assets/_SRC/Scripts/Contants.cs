using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.TosomaTomaya.core
{
    public class Contants
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
            public static GameObject FIREBALL = Resources.Load("Prefab/Fireball") as GameObject;
        }
    }
}


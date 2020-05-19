using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;

namespace com.TosomaTomaya.pool
{
    public class PoolObjects
    {
        private static PoolObjects _instances;
        public static PoolObjects instances
        {
            get 
            {
                if (_instances == null)
                {
                    _instances = new PoolObjects();
                }
                return _instances;
            }
        }

        private static List<GameObject> pool = new List<GameObject>();

        public void Init(GameObject prefab, int tamaño)
        {
            for (int i = 0; i < tamaño; i++)
            {
                GameObject inst = MonoBehaviour.Instantiate(prefab);
                inst.SetActive(false);
                pool.Add(inst);
            }
        }

        public void SetReActive(Vector3 poss)
        {
            if (pool.Count > 0)
            {
                for (int i = 0; i < pool.Count; i++)
                {
                    if (!pool[i].gameObject.activeSelf)
                    {
                        pool[i].transform.position = poss;
                        pool[i].SetActive(true);
                        break;
                    }
                }
            }
            else
            {
                Debug.LogError("NO EXISTE POOL DE OBJETO");
            }
        }
    }


}



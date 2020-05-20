using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.TosomaTomaya.pjs;
using com.TosomaTomaya.pool;
using com.TosomaTomaya.core;

public class TEST : MonoBehaviour
{
    public Transform target;
    GameObject pref;
    GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("Spawn");
        Pjs.init();
        pref = Contants.PREFAB.FIREBALL;
        pref.SetActive(false);
        PoolObjects.instances.Init(pref, 5);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestClick()
    {
        PoolObjects.instances.SetReActive(spawn.transform.position);
    }

}

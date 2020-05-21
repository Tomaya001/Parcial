using com.TosomaTomaya.core;
using com.TosomaTomaya.pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpells : MonoBehaviour
{
    static List<GameObject> spellsPool;
    public int cant;

    GameObject pref;
    GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        spellsPool = new List<GameObject>();
        spawn = GameObject.Find("Spawn");
        pref = Resources.Load(Constants.PREFAB.FIREBALL) as GameObject;
        pref.SetActive(false);
        PoolObjects.instances.CrearPool(spellsPool, pref, cant);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireClick()
    {
        PoolObjects.instances.SetReActive(spellsPool,spawn.transform.position);
    }
}

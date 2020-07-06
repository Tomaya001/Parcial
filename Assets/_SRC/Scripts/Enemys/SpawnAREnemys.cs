using com.TosomaTomaya.core;
using com.TosomaTomaya.pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAREnemys : MonoBehaviour
{
    static List<GameObject> enemysPool;

    List<GameObject> enemys;
    public float time;
    public int cant;

    // Start is called before the first frame update
    private void Awake()
    {
        enemys = new List<GameObject>();
        enemysPool = new List<GameObject>();
        enemys.Add(Resources.Load(Constants.PREFAB.ENEMY1) as GameObject);
        enemys.Add(Resources.Load(Constants.PREFAB.ENEMY2) as GameObject);
        CrearPool();
    }

    void CrearPool()
    {
        if (enemysPool.Count <= 0)
        {
            PoolObjects.instances.CrearPool(enemysPool, enemys[Random.Range(0, enemys.Count)], cant);
        }        
    }

    IEnumerator EnemysSpawn()
    { 
        PoolObjects.instances.SetReActive(enemysPool, transform.position);

        yield return new WaitForSeconds(time);
        StartCoroutine(EnemysSpawn());
    }

    public void StartSpawn()
    {
        StartCoroutine(EnemysSpawn());
    }

    public void StopSpawn()
    {
        StopAllCoroutines();
    }
}

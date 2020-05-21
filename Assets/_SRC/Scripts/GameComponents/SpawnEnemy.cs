using com.TosomaTomaya.core;
using com.TosomaTomaya.pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    static List<GameObject> enemysPool;

    List<GameObject> enemys;
    List<Vector3> portalsEnableds;
    public float time;
    public int cant;

    // Start is called before the first frame update
    void Start()
    {
        enemys = new List<GameObject>();
        enemysPool = new List<GameObject>();
        portalsEnableds = new List<Vector3>();
        enemys.Add(Resources.Load(Constants.PREFAB.ENEMY1) as GameObject);
        enemys.Add(Resources.Load(Constants.PREFAB.ENEMY2) as GameObject);
        StartCoroutine(EnemysSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemysSpawn()
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < SpawnPortals.portalsPool.Count; i++)
        {
            if(SpawnPortals.portalsPool[i].activeSelf)
            {
                portalsEnableds.Add(SpawnPortals.portalsPool[i].transform.position);
            }
        }
        if (enemysPool.Count <= 0)
        {
            PoolObjects.instances.CrearPool(enemysPool, enemys[Random.Range(0,enemys.Count)], cant);
        }

        PoolObjects.instances.SetReActive(enemysPool, portalsEnableds[Random.Range(0,portalsEnableds.Count)]);

        yield return new WaitForSeconds(time);
        StartCoroutine(EnemysSpawn());
    }
}

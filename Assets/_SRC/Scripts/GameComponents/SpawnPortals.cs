using com.TosomaTomaya.core;
using com.TosomaTomaya.pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortals : MonoBehaviour
{
    public static List<GameObject> portalsPool;
    public GameObject[] spawnsPoints;
    public float time;

    GameObject portal;

    // Start is called before the first frame update
    void Start()
    {
        portalsPool = new List<GameObject>();
        portal = Resources.Load(Constants.PREFAB.PORTALS) as GameObject;
        StartCoroutine(PortalSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PortalSpawn()
    {
        if (portalsPool.Count <= 0)
        {
            PoolObjects.instances.CrearPool(portalsPool,portal,5);
        }
        PoolObjects.instances.SetReActive(portalsPool, spawnsPoints[Random.Range(0, spawnsPoints.Length)].transform.position);

        yield return new WaitForSeconds(time);
        StartCoroutine(PortalSpawn());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.TosomaTomaya.pjs;
using com.TosomaTomaya.pool;

public class TEST : MonoBehaviour
{
    GameObject pref;
    // Start is called before the first frame update
    void Start()
    {
        Pjs.init();
        pref = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        pref.layer = 31;
        pref.AddComponent<ProyectileComponet>();
        pref.AddComponent<Rigidbody>();
        pref.AddComponent<Collider>();
        pref.SetActive(false);
        PoolObjects.instances.Init(pref, 5);

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestClick()
    {
        PoolObjects.instances.SetReActive(Vector3.zero);
    }

}

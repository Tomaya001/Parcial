using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalComponent : MonoBehaviour
{
    Transform playerPoos;
    Transform t;

    void Start()
    {
        playerPoos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        t = transform;
        t.LookAt(playerPoos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

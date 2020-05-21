using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform player;
    Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = transform;
    }

    // Update is called once per frame
    void Update()
    {
        t.position = new Vector3(player.position.x, player.position.y + 5f, player.position.z - 10f);
        t.rotation = player.rotation;
    }
}

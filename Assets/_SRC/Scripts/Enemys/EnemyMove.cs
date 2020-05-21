using com.TosomaTomaya.core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Transform t;
    Transform playerPos;

    public int vida = 2;
    public int speed = 5;


    // Start is called before the first frame update
    void Start()
    {
        t = transform;
        playerPos = GameObject.FindGameObjectWithTag(Constants.TAG.PLAYER).GetComponent<Transform>();
        StartCoroutine(Vida());
    }

    private void Update()
    {
        t.LookAt(playerPos);
        t.Translate(t.forward * -1 * speed * Time.deltaTime);
    }

    IEnumerator Vida()
    {
        while(vida >0)
        {
            yield return null;
        }
        Variables.puntos++;
        this.gameObject.SetActive(false);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer.Equals(Constants.LAYERS.PLAYERPROYECTILE))
        {
            vida--;
        }

    }
}

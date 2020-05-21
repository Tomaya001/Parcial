using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileComponet : MonoBehaviour
{
    public Transform target;
    public Transform t;
    public Rigidbody rb;
    public float speed;
    public float time;

    AudioSource source;

    // Start is called before the first frame update
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    private void OnEnable()
    {
        target = GameObject.Find("Target").transform;
        Launch();
        Invoke("DisableMe", time);
    }

    public void Launch()
    {
        t.LookAt(target);
        rb.velocity = transform.forward * speed;
        source.Play();
    }

    void DisableMe()
    {
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        DisableMe();
    }

}

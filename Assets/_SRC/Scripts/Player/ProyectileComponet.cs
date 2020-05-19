using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileComponet : MonoBehaviour
{
    Transform t;
    float speed;
    Vector3 target;


    private void Awake()
    {
        t = transform;
        speed = 50f;
    }

    private void OnEnable()
    {
        target = Camera.main.ViewportPointToRay(t.position).GetPoint(200f);
        Debug.Log(target);
        t.LookAt(target);
        IEnumerator mirutina = Move(target, speed);
        StartCoroutine(mirutina);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, target, Color.red);
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }

    IEnumerator Move(Vector3 possf, float speed)
    {
        while(t.position.y < possf.y)
        {
            t.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        yield return null;
    }

}

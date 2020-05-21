using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCustom : MonoBehaviour
{
    public bool desactiveinXSeconds;
    public float time;

    private void Start()
    {
        if(desactiveinXSeconds)
        {
            Invoke("DisableMe", time);
        }
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

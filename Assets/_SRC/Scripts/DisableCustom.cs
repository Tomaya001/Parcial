using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCustom : MonoBehaviour
{
    public bool desactiveinXSeconds;
    public float time;
    public bool disableChields;

    private void Start()
    {
        if(desactiveinXSeconds)
        {
            Invoke("DisableMe", time);
        }
    }

    void DisableMe()
    {
        if (disableChields)
        {
            gameObject.SetActiveRecursively(false);
        }
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        DisableMe();
    }
}

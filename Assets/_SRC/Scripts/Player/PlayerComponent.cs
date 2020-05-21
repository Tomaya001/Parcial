using com.TosomaTomaya.core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerComponent : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WinCondition());
    }

    IEnumerator WinCondition()
    {
        while(Variables.puntos <10)
        {
            yield return null;
        }
        SceneManager.LoadSceneAsync(Constants.SCENES.YOUWIN);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer.Equals(Constants.LAYERS.ENEMY))
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadSceneAsync(Constants.SCENES.GAMEOVER);
        }
    }
}

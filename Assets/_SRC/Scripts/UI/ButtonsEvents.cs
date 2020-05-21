using com.TosomaTomaya.core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsEvents: MonoBehaviour
{
    IEnumerator myCor;

    public void RunGame()
    {
        myCor = Wait(Constants.SCENES.GAMEPLAY);
        StartCoroutine(myCor);
    }

    public void MenuLoad()
    {
        myCor = Wait(Constants.SCENES.MAIN);
        StartCoroutine(myCor);
    }

    public void Exit()
    {
        Application.Quit();
    }

    IEnumerator Wait(string scene)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadSceneAsync(scene);
    }
}

using com.TosomaTomaya.core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsEvents: MonoBehaviour
{
    public void RunGame()
    {
        SceneManager.LoadSceneAsync(Constants.SCENES.GAMEPLAY);
    }

    public void MenuLoad()
    {
        SceneManager.LoadSceneAsync(Constants.SCENES.MAIN);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

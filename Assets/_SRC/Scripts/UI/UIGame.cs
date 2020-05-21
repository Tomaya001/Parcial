using com.TosomaTomaya.core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    public Text puntos;

    private void LateUpdate()
    {
        puntos.text = "PUNTOS: " + Variables.puntos;
    }
}

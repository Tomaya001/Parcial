using com.TosomaTomaya.core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimation : MonoBehaviour
{
    private float yOffset = 0;

    private void Start() {

        Canvas[] canvas = GameObject.FindObjectsOfType<Canvas>();
        for(int i = 0; i < canvas.Length; i++) {
            if (canvas[i].tag.Equals(Constants.TAG.MAIN)) {
                yOffset = canvas[i].GetComponent<RectTransform>().rect.height;
            }
        }

    }

    public void EnableWindow() {
        
        gameObject.SetActive(true);
        LeanTween.move(GetComponent<RectTransform>(), new Vector3(0, 0, 0), 1f).setEaseInOutBack();

    }

    public void DisableWindow() {

        LeanTween.move(GetComponent<RectTransform>(), new Vector3(0, yOffset, 0), 1f).setEaseInOutBack().setOnComplete(
            () => {
                gameObject.SetActive(false);
            }
        );
    }
    

}

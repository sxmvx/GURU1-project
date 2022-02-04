using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseControll : MonoBehaviour
{
    [SerializeField] GameObject buttonStop;
    [SerializeField] GameObject buttonStart;
    bool pauseActive = false;

    void Start()
    {
        buttonStart.gameObject.SetActive(false);
    }

    public void pauseBtn()
    {
        if(pauseActive)
        {
            buttonStop.gameObject.SetActive(true);
            buttonStart.gameObject.SetActive(false);
            Time.timeScale = 1;
            pauseActive = false;
        }
        else
        {
            buttonStart.gameObject.SetActive(true);
            buttonStop.gameObject.SetActive(false);
            Time.timeScale = 0;
            pauseActive = true;
        }
        
    }
}

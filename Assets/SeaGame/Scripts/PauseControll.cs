using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseControll : MonoBehaviour
{
    [SerializeField] GameObject Stop;
    [SerializeField] GameObject Restart;
    bool pauseActive = false;

    public void pauseBtn()
    {
        if(pauseActive)
        {
            Time.timeScale = 1;
            pauseActive = false;
            Stop.gameObject.SetActive(true);

        }
        else
        {
            Time.timeScale = 0;
            pauseActive = true;
            Restart.gameObject.SetActive(true);
            Stop.gameObject.SetActive(false);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject Good;
    [SerializeField] float currentTime = 0;
    [SerializeField] float maxTime = 5f;
    Image TimeBar;
    

    void Start()
    {
        Good.SetActive(false);
        TimeBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(maxTime > currentTime)
        {
            currentTime += Time.deltaTime;
            TimeBar.fillAmount = currentTime/maxTime;
        }
        else
        {
            Good.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

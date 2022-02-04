using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
    [SerializeField] GameObject Good;
    [SerializeField] float currentTime = 0;
    [SerializeField] float maxTime = 5f;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Obstacle;
    [SerializeField] GameObject BlackBackground;
    [SerializeField] GameObject NEXT;
    [SerializeField] GameObject STOP;
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
            Player.SetActive(false);
            Obstacle.SetActive(false);
            BlackBackground.SetActive(true);
            NEXT.SetActive(true);
            STOP.SetActive(false);
        }
    }
}

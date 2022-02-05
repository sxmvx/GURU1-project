using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] GameObject Great;
    [SerializeField] GameObject NextButton;
    [SerializeField] GameObject GameText;
    private AudioSource BackgroundSound;


    void Start()
    {
        Great.gameObject.SetActive(false);
        NextButton.gameObject.SetActive(false);
        BackgroundSound = GetComponent<AudioSource>();
    }
   
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BackgroundSound.Stop();
        Great.gameObject.SetActive(true);
        NextButton.gameObject.SetActive(true);
        GameText.gameObject.SetActive(false);
    }
}

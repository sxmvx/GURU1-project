using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] GameObject Great;
    [SerializeField] GameObject NextButton;
    public UnityEngine.UI.Text MainText;

    void Start()
    {
        Great.gameObject.SetActive(false);
        NextButton.gameObject.SetActive(false);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Great.gameObject.SetActive(true);
        NextButton.gameObject.SetActive(true);
        MainText.gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour //오브젝트 변수명 정리하기
{
    [SerializeField] GameObject GameTitle;
    [SerializeField] GameObject Start1;
    [SerializeField] GameObject BlackBackground;
    [SerializeField] GameObject GameRule;
    [SerializeField] GameObject GameRuleScreen;
    [SerializeField] GameObject start2;
    [SerializeField] GameObject GameText;



    void Start()
    {
        start2.gameObject.SetActive(false);
        GameRuleScreen.gameObject.SetActive(false);
        GameText.gameObject.SetActive(false);
    }
   
    public void OnclickStart()
    {
        Destroy(GameTitle);
        Destroy(Start1);
        Destroy(BlackBackground);
        Destroy(GameRule);
        start2.gameObject.SetActive(false);
        GameRuleScreen.gameObject.SetActive(false);
        GameText.gameObject.SetActive(true);

    }
    public void OnclickRule()
    {
        Destroy(GameTitle);
        Destroy(Start1);
        Destroy(GameRule);
        start2.gameObject.SetActive(true);
        GameRuleScreen.gameObject.SetActive(true);

    }
    public void OnclickStart2()
    {
        Destroy(BlackBackground);
        Destroy(GameRuleScreen);
        Destroy(start2);
        GameText.gameObject.SetActive(true);


    }
   
}

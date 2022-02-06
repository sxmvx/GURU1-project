using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaGameStart : MonoBehaviour
{
    public bool pauseActive = false;

    [SerializeField] GameObject UnderTheSea;
    [SerializeField] GameObject Start1;
    [SerializeField] GameObject Start2;
    [SerializeField] GameObject SeaGameRule;
    [SerializeField] GameObject SeaGameRuleBTN;
    [SerializeField] GameObject SeaGameRule2;
    [SerializeField] GameObject Next;
    [SerializeField] GameObject Return;

    void Start()
    {

        //게임방법창, Next버튼, 이전으로 버튼, start2버튼 비활성화
        SeaGameRule.gameObject.SetActive(false);
        SeaGameRule2.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
        Return.gameObject.SetActive(false);
        Start2.gameObject.SetActive(false);

    }

    public void OnClickStart1()
    {
        UnderTheSea.gameObject.SetActive(false);
        Start1.gameObject.SetActive(false);
        SeaGameRuleBTN.gameObject.SetActive(false);
    }

    public void OnClickRule()
    {
        //게임방법창1, Next버튼, 이전으로 버튼 활성화
        SeaGameRule.gameObject.SetActive(true);
        Next.gameObject.SetActive(true);
        //start1버튼, underthesea 창 비활성화
        Start1.gameObject.SetActive(false);
        UnderTheSea.gameObject.SetActive(false);
        SeaGameRuleBTN.gameObject.SetActive(false);
    }
    public void OnClickNext()
    {
        //게임방법창1, Next버튼, 이전으로 버튼 비활성화
        SeaGameRule.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
        //게임방법창2, start2버튼, 이전으로 버튼 활성화
        SeaGameRule2.gameObject.SetActive(true);
        Return.gameObject.SetActive(true);
        Start2.gameObject.SetActive(true);
    }
    public void OnClickStart2()
    {
       
    }
    public void OnClickReturn()
    {
        //게임방법창1, Next버튼, 이전으로 버튼 활성화
        SeaGameRule.gameObject.SetActive(true);
        Next.gameObject.SetActive(true);
        //게임방법창1, Next버튼, 이전으로 버튼 비활성화
        Return.gameObject.SetActive(false);
        Start2.gameObject.SetActive(false);
        SeaGameRule2.gameObject.SetActive(false);
    }
}

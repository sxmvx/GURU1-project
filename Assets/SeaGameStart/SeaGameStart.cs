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

        //���ӹ��â, Next��ư, �������� ��ư, start2��ư ��Ȱ��ȭ
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
        //���ӹ��â1, Next��ư, �������� ��ư Ȱ��ȭ
        SeaGameRule.gameObject.SetActive(true);
        Next.gameObject.SetActive(true);
        //start1��ư, underthesea â ��Ȱ��ȭ
        Start1.gameObject.SetActive(false);
        UnderTheSea.gameObject.SetActive(false);
        SeaGameRuleBTN.gameObject.SetActive(false);
    }
    public void OnClickNext()
    {
        //���ӹ��â1, Next��ư, �������� ��ư ��Ȱ��ȭ
        SeaGameRule.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
        //���ӹ��â2, start2��ư, �������� ��ư Ȱ��ȭ
        SeaGameRule2.gameObject.SetActive(true);
        Return.gameObject.SetActive(true);
        Start2.gameObject.SetActive(true);
    }
    public void OnClickStart2()
    {
       
    }
    public void OnClickReturn()
    {
        //���ӹ��â1, Next��ư, �������� ��ư Ȱ��ȭ
        SeaGameRule.gameObject.SetActive(true);
        Next.gameObject.SetActive(true);
        //���ӹ��â1, Next��ư, �������� ��ư ��Ȱ��ȭ
        Return.gameObject.SetActive(false);
        Start2.gameObject.SetActive(false);
        SeaGameRule2.gameObject.SetActive(false);
    }
}

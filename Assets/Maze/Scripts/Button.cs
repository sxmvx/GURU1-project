using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour //������Ʈ ������ �����ϱ�
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject obj2;
    [SerializeField] GameObject obj3;
    [SerializeField] GameObject obj4;
    [SerializeField] GameObject obj5;
    [SerializeField] GameObject obj6;
    public UnityEngine.UI.Text MainText;


    void Start()
    {
        obj6.gameObject.SetActive(false);
        obj5.gameObject.SetActive(false);
        MainText.gameObject.SetActive(false);
    }
   
    public void OnclickStart()
    {
        Destroy(obj);
        Destroy(obj2);
        Destroy(obj3);
        Destroy(obj4);
        obj6.gameObject.SetActive(false);
        obj5.gameObject.SetActive(false);
        MainText.gameObject.SetActive(true);

    }
    public void OnclickRule()
    {
        Destroy(obj);
        Destroy(obj2);
        Destroy(obj4);
        obj6.gameObject.SetActive(true);
        obj5.gameObject.SetActive(true);

    }
    public void OnclickStart2()
    {
        Destroy(obj3);
        Destroy(obj5);
        Destroy(obj6);
        MainText.gameObject.SetActive(true);
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionData : MonoBehaviour
{
    private int loyalty=5;
    private int freedom=5;
    private int rabbit=5;
    private int greed=5;
    public GameObject Button1, Button2;

    public void upLoyalty()
{
    loyalty++;
        Debug.Log(loyalty);
}

    public void upFreedom()
{
    freedom++;
        Debug.Log(freedom);
    }

    public void upRabbit()
{
    rabbit++;
        Debug.Log(rabbit);
    }

    public void upGreed()
{
    greed++;
        Debug.Log(greed);
    }
    public void downLoyalty()
    {
        loyalty--;
        Debug.Log(loyalty);
    }

    public void activeFalseButton()
    {
        Button1.gameObject.SetActive(false);
        Button2.gameObject.SetActive(false);
    }

}

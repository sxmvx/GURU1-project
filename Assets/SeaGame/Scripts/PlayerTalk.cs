using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTalk : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject TalkText;
    [SerializeField] GameObject TalkPlace;
    [SerializeField] GameObject TalkButton;

    void Start()
    {
        
    }
  
    
    public void OnClickTalk()
    {
        
        Player.gameObject.SetActive(false);
        TalkText.gameObject.SetActive(false);
        TalkPlace.gameObject.SetActive(false);
        TalkButton.gameObject.SetActive(false);
        Time.timeScale = 1;

    }

}

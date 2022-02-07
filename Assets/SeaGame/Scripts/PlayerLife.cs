using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField]
    private float maxLife = 3; //최대 생명
    private float currentLife; //현재 생명
    private SpriteRenderer spriteRenderer;
    [SerializeField] GameObject life1;
    [SerializeField] GameObject life2;
    [SerializeField] GameObject life3;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Obstacle;
    [SerializeField] GameObject BlackBackground;
    [SerializeField] GameObject GameOver;
    [SerializeField] GameObject NEXT;
    [SerializeField] GameObject STOP;
    [SerializeField] GameObject Restart;




    void Start()
    {
        NEXT.gameObject.SetActive(false);
        BlackBackground.gameObject.SetActive(false);
        GameOver.gameObject.SetActive(false);
    }

    private void Awake()
    {
        currentLife = maxLife; //현재체력 = 최대체력
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        //현재 생명을 damage만큼 감소
        currentLife -= damage;
        
        //PlayerLifeIcon 비활성화
        if(currentLife==2)
        { life1.gameObject.SetActive(false);}
        else if (currentLife == 1)
        { life2.gameObject.SetActive(false);}
        //체력이 0이하 = 플레이어 사망
        else if (currentLife == 0)
        {life3.gameObject.SetActive(false);
         GameOver.gameObject.SetActive(true);
         BlackBackground.gameObject.SetActive(true);
         NEXT.gameObject.SetActive(true);
         STOP.gameObject.SetActive(false);
         Restart.SetActive(false);
         Time.timeScale = 0;
        }

        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");
    }
    private IEnumerator HitColorAnimation()
        {
            //Player색상 빨간색으로
            spriteRenderer.color = Color.red;
            //0.1초 대기
            yield return new WaitForSeconds(0.1f);
            //플레이어 색상 원래 색상으로
            spriteRenderer.color = Color.white;
        }
}

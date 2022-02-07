using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField]
    private float maxLife = 3; //�ִ� ����
    private float currentLife; //���� ����
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
        currentLife = maxLife; //����ü�� = �ִ�ü��
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        //���� ������ damage��ŭ ����
        currentLife -= damage;
        
        //PlayerLifeIcon ��Ȱ��ȭ
        if(currentLife==2)
        { life1.gameObject.SetActive(false);}
        else if (currentLife == 1)
        { life2.gameObject.SetActive(false);}
        //ü���� 0���� = �÷��̾� ���
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
            //Player���� ����������
            spriteRenderer.color = Color.red;
            //0.1�� ���
            yield return new WaitForSeconds(0.1f);
            //�÷��̾� ���� ���� ��������
            spriteRenderer.color = Color.white;
        }
}

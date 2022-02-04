using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Dialogue_TM
{
    [TextArea]//���� ���� ���� �� �� �� �ְ� ����
    public string dialogue;
    public Sprite cg; // ��ü�� �̹���

}

public class TM : MonoBehaviour
{
    //SerializeField : inspectorâ���� ���� ������ �� �ֵ��� �ϴ� ������.
    [SerializeField] private SpriteRenderer sprite_StandingCG; //ĳ���� �̹���(YK)�� �����ϱ� ���� ����
    public GameObject dialogueBox; //���â �̹���(crop)�� �����ϱ� ���� ����
    public GameObject Button1, Button2, Button3, Button4, image1, image2, image3, image4;
    public Animator animator;
    [SerializeField] private Text txt_Dialogue; // �ؽ�Ʈ�� �����ϱ� ���� ����

    private bool isDialogue = false; //��ȭ�� ���������� �˷��� ����
    private int count = 0; //��簡 �󸶳� ����ƴ��� �˷��� ����

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue_TM()
    {
        if(Button1!=null&&Button2!=null)
        {
            Button1.gameObject.SetActive(false);
            Button2.gameObject.SetActive(false);
        }
        
        ONOFF_TM(true); //��ȭ�� ���۵�
        count = 0;
        NextDialogue_TM(); //ȣ����ڸ��� ��簡 ����� �� �ֵ��� 
    }

    private void ONOFF_TM(bool _flag)
    {
        dialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

    private void NextDialogue_TM()
    {
        //ù��° ���� ù��° cg���� ��� ���� cg�� ����Ǹ鼭 ȭ�鿡 ���̰� �ȴ�. 
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++; //���� ���� cg�� �������� 

    }

    void Start()
    {
        animator.SetBool("isPushed", false);
    }

    public void IsPushed()
    {
        animator.SetBool("isPushed", true);
        animator.SetFloat("state", 1);
    }

    // Update is called once per frame
    void Update()
    {
        //spacebar ���� ������ ��簡 ����ǵ���. 
        if (isDialogue) //Ȱ��ȭ�� �Ǿ��� ���� ��簡 ����ǵ���
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //��ȭ�� ���� �˾ƾ���.
                if (count < dialogue.Length) NextDialogue_TM(); //���� ��簡 �����
                else
                {
                    ONOFF_TM(false);

                    if (Button3 != null && Button4 != null)
                    {
                        Button3.gameObject.SetActive(true);
                        Button4.gameObject.SetActive(true);
                    }
                    else if(Button4!=null)
                        Button4.gameObject.SetActive(true);
                    else if(Button3!=null)
                        Button3.gameObject.SetActive(true);

                    if (Button3!=null&&Button4!=null)
                    {
                        Button3.gameObject.SetActive(true);
                        Button4.gameObject.SetActive(true);
                    }

                    if (image1 != null && image2 != null)
                    {
                        IsPushed();
                        image1.gameObject.SetActive(false);
                        image2.gameObject.SetActive(true);
                        image3.gameObject.SetActive(false);
                        image4.gameObject.SetActive(true);
                    }

                }
             }
        }

    }
}

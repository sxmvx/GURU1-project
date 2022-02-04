using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Dialogue
{
    [TextArea]//���� ���� ���� �� �� �� �ְ� ����
    public string dialogue;
    public Sprite cg; // ��ü�� �̹���

}

public class TextManager : MonoBehaviour
{
    //SerializeField : inspectorâ���� ���� ������ �� �ֵ��� �ϴ� ������.
    [SerializeField] private SpriteRenderer sprite_StandingCG; //ĳ���� �̹���(YK)�� �����ϱ� ���� ����
    public GameObject dialogueBox; //���â �̹���(crop)�� �����ϱ� ���� ����
    public GameObject Button1, Button2;
    [SerializeField] private Text txt_Dialogue; // �ؽ�Ʈ�� �����ϱ� ���� ����

    private bool isDialogue = false; //��ȭ�� ���������� �˷��� ����
    private int count = 0; //��簡 �󸶳� ����ƴ��� �˷��� ����

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue()
    {
        ONOFF(true); //��ȭ�� ���۵�
        count = 0;
        NextDialogue(); //ȣ����ڸ��� ��簡 ����� �� �ֵ��� 
    }

    private void ONOFF(bool _flag)
    {
        dialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

    private void NextDialogue()
    {
        //ù��° ���� ù��° cg���� ��� ���� cg�� ����Ǹ鼭 ȭ�鿡 ���̰� �ȴ�. 
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++; //���� ���� cg�� �������� 

    }

    void Start()
    {
        ShowDialogue();
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
                if (count < dialogue.Length) NextDialogue(); //���� ��簡 �����
                else
                {
                    ONOFF(false);
                    if (Button1 != null && Button2 != null)
                    {
                        Button1.gameObject.SetActive(true);
                        Button2.gameObject.SetActive(true);
                    }//��簡 ����
                }

            }
        }
    }
}

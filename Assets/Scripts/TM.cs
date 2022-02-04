using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Dialogue_TM
{
    [TextArea]//한줄 말고 여러 줄 쓸 수 있게 해줌
    public string dialogue;
    public Sprite cg; // 교체될 이미지

}

public class TM : MonoBehaviour
{
    //SerializeField : inspector창에서 직접 접근할 수 있도록 하는 변수임.
    [SerializeField] private SpriteRenderer sprite_StandingCG; //캐릭터 이미지(YK)를 제어하기 위한 변수
    public GameObject dialogueBox; //대사창 이미지(crop)를 제어하기 위한 변수
    public GameObject Button1, Button2, Button3, Button4, image1, image2, image3, image4;
    public Animator animator;
    [SerializeField] private Text txt_Dialogue; // 텍스트를 제어하기 위한 변수

    private bool isDialogue = false; //대화가 진행중인지 알려줄 변수
    private int count = 0; //대사가 얼마나 진행됐는지 알려줄 변수

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue_TM()
    {
        if(Button1!=null&&Button2!=null)
        {
            Button1.gameObject.SetActive(false);
            Button2.gameObject.SetActive(false);
        }
        
        ONOFF_TM(true); //대화가 시작됨
        count = 0;
        NextDialogue_TM(); //호출되자마자 대사가 진행될 수 있도록 
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
        //첫번째 대사와 첫번째 cg부터 계속 다음 cg로 진행되면서 화면에 보이게 된다. 
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++; //다음 대사와 cg가 나오도록 

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
        //spacebar 누를 때마다 대사가 진행되도록. 
        if (isDialogue) //활성화가 되었을 때만 대사가 진행되도록
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //대화의 끝을 알아야함.
                if (count < dialogue.Length) NextDialogue_TM(); //다음 대사가 진행됨
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC01 : MonoBehaviour
{
    Transform player;

    // 게임 상태 UI 오브젝트 변수
    public GameObject dialogue;
    public GameObject t_box;

    // 게임 상태 UI 텍스트 컴포넌트 변수
    Text text;

    // 초기 위치 저장용 변수
    Vector3 originPos;

    public int clickCount = 0;

    void Start()
    {
        // 플레이어의 트랜스폼 컴포넌트 받아오기
        player = GameObject.Find("Player").transform;

        // 게임 상태 UI 오브젝트에서 Text 컴포넌트를 가져온다.
        text = dialogue.GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            dialogue.SetActive(true);
            t_box.SetActive(true);

            if (clickCount == 0)
            {
                t_box.SetActive(true);
                text.text = "나는 NPC01이야.\n테스트 메시지야.";

            }

            else if (clickCount == 1)
            {
                t_box.SetActive(false);
                t_box.SetActive(true);
                text.text = "for문으로 작성해 봐야지.\n테스트 메시지야.";
            }

            else if (clickCount == 2)
            {
                t_box.SetActive(false);
                t_box.SetActive(true);
                text.text = "아예 함수를 만들까?\n테스트 메시지야.";
            }

            else
            {
                dialogue.SetActive(false);
                t_box.SetActive(false);
            }     
        }
    }
}

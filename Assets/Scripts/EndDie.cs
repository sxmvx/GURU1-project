using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndDie : MonoBehaviour
{
    // 싱글톤 변수
    public static EndDie gm;

    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
    }

    // 게임 상태 상수
    public enum GameState
    {
        Ready,
        Run
    }

    // 현재의 게임 상태 변수
    public GameState gState;

    // 게임 상태 UI 오브젝트 변수
    public GameObject gameLabel;
    public GameObject gamePanel;

    // 게임 상태 UI 텍컴포넌트 변수
    Text gameText;

    void Start()
    {
        // 초기 게임 상태는 준비 상태로 설정한다.
        gState = GameState.Ready;

        // 게임 상태 UI 오브젝트에서 Text 컴포넌트를 가져온다.
        gameText = gameLabel.GetComponent<Text>();

        gameLabel.SetActive(true);
        gamePanel.SetActive(true);

        // 상태 텍스트의 내용을 ‘Ready...’로 한다.
        gameText.text = "~Ending 용왕의 죽음~";

        // 게임 준비 -> 게임 중 상태로 전환하기
        StartCoroutine(ReadyToMove());

    }

    IEnumerator ReadyToMove()
    {// 2초간 대기한다.
        yield return new WaitForSeconds(2f);
        // 상태 텍스트의 내용
        gameText.text = "토끼는 도망갔습니다.";
        // 2초간 대기한다.
        yield return new WaitForSeconds(2f);
        // 상태 텍스트의 내용
        gameText.text = "당신은 토끼를 놓쳤고, 용왕님은 병이 악화되었습니다.";
        // 2초간 대기한다.
        yield return new WaitForSeconds(2f);
        // 상태 텍스트의 내용
        gameText.text = "용왕님은 결국 죽음에 이르렀습니다.";
        // 2초간 대기한다.
        yield return new WaitForSeconds(2f);
        // 상태 텍스트의 내용
        gameText.text = "용궁은 슬픔과 혼란에 빠졌습니다.";
        // 2초간 대기한다.
        yield return new WaitForSeconds(2f);
        // 상태 텍스트의 내용
        gameText.text = "~Ending 용왕의 죽음~";
        // 3초간 대기한다.
        yield return new WaitForSeconds(3f);
        // 상태 텍스트를 비활성화한다.
        gameLabel.SetActive(false);
        gamePanel.SetActive(false);
        // 상태를 ‘게임중’ 상태로 변경한다.
        gState = GameState.Run;
    }
}


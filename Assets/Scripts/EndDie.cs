using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndDie : MonoBehaviour
{
    // �̱��� ����
    public static EndDie gm;

    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
    }

    // ���� ���� ���
    public enum GameState
    {
        Ready,
        Run
    }

    // ������ ���� ���� ����
    public GameState gState;

    // ���� ���� UI ������Ʈ ����
    public GameObject gameLabel;
    public GameObject gamePanel;

    // ���� ���� UI ��������Ʈ ����
    Text gameText;

    void Start()
    {
        // �ʱ� ���� ���´� �غ� ���·� �����Ѵ�.
        gState = GameState.Ready;

        // ���� ���� UI ������Ʈ���� Text ������Ʈ�� �����´�.
        gameText = gameLabel.GetComponent<Text>();

        gameLabel.SetActive(true);
        gamePanel.SetActive(true);

        // ���� �ؽ�Ʈ�� ������ ��Ready...���� �Ѵ�.
        gameText.text = "~Ending ����� ����~";

        // ���� �غ� -> ���� �� ���·� ��ȯ�ϱ�
        StartCoroutine(ReadyToMove());

    }

    IEnumerator ReadyToMove()
    {// 2�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(2f);
        // ���� �ؽ�Ʈ�� ����
        gameText.text = "�䳢�� ���������ϴ�.";
        // 2�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(2f);
        // ���� �ؽ�Ʈ�� ����
        gameText.text = "����� �䳢�� ���ư�, ��մ��� ���� ��ȭ�Ǿ����ϴ�.";
        // 2�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(2f);
        // ���� �ؽ�Ʈ�� ����
        gameText.text = "��մ��� �ᱹ ������ �̸������ϴ�.";
        // 2�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(2f);
        // ���� �ؽ�Ʈ�� ����
        gameText.text = "����� ���İ� ȥ���� �������ϴ�.";
        // 2�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(2f);
        // ���� �ؽ�Ʈ�� ����
        gameText.text = "~Ending ����� ����~";
        // 3�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(3f);
        // ���� �ؽ�Ʈ�� ��Ȱ��ȭ�Ѵ�.
        gameLabel.SetActive(false);
        gamePanel.SetActive(false);
        // ���¸� �������ߡ� ���·� �����Ѵ�.
        gState = GameState.Run;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM_6 : MonoBehaviour
{
    // �̱��� ����
    public static GM_6 gm;

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

    // PlayerMove Ŭ���� ����
    PlayerMove player;

    void Start()
    {
        // �ʱ� ���� ���´� �غ� ���·� �����Ѵ�.
        gState = GameState.Ready;

        // ���� ���� UI ������Ʈ���� Text ������Ʈ�� �����´�.
        gameText = gameLabel.GetComponent<Text>();

        gameLabel.SetActive(true);
        gamePanel.SetActive(true);

        // ���� �ؽ�Ʈ�� ������ ��Ready...���� �Ѵ�.
        gameText.text = "�� 6��";

        // ���� �غ� -> ���� �� ���·� ��ȯ�ϱ�
        StartCoroutine(ReadyToMove());

        // �÷��̾� ������Ʈ�� ã�� �� �÷��̾��� PlayerMove ������Ʈ �޾ƿ���
        player = GameObject.Find("Player").GetComponent<PlayerMove>();
    }

    IEnumerator ReadyToMove()
    {
        // 2�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(2f);
        // ���� �ؽ�Ʈ�� ������ ��Go!���� �Ѵ�.
        gameText.text = "�ٽ� �������";
        // 3�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(3f);
        // ���� �ؽ�Ʈ�� ��Ȱ��ȭ�Ѵ�.
        gameLabel.SetActive(false);
        gamePanel.SetActive(false);
        // ���¸� �������ߡ� ���·� �����Ѵ�.
        gState = GameState.Run;
    }
}


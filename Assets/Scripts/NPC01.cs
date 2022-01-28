using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC01 : MonoBehaviour
{
    Transform player;

    // ���� ���� UI ������Ʈ ����
    public GameObject dialogue;
    public GameObject t_box;

    // ���� ���� UI �ؽ�Ʈ ������Ʈ ����
    Text text;

    // �ʱ� ��ġ ����� ����
    Vector3 originPos;

    public int clickCount = 0;

    void Start()
    {
        // �÷��̾��� Ʈ������ ������Ʈ �޾ƿ���
        player = GameObject.Find("Player").transform;

        // ���� ���� UI ������Ʈ���� Text ������Ʈ�� �����´�.
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
                text.text = "���� NPC01�̾�.\n�׽�Ʈ �޽�����.";

            }

            else if (clickCount == 1)
            {
                t_box.SetActive(false);
                t_box.SetActive(true);
                text.text = "for������ �ۼ��� ������.\n�׽�Ʈ �޽�����.";
            }

            else if (clickCount == 2)
            {
                t_box.SetActive(false);
                t_box.SetActive(true);
                text.text = "�ƿ� �Լ��� �����?\n�׽�Ʈ �޽�����.";
            }

            else
            {
                dialogue.SetActive(false);
                t_box.SetActive(false);
            }     
        }
    }
}

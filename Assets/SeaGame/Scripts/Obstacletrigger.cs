using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacletrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //������ �ε��� ������Ʈ �±װ� "Player"���
        if (collision.CompareTag("Player"))
        {
            //���� ����
            Destroy(gameObject);
        }
    }
}

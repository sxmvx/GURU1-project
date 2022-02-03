using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacletrigger : MonoBehaviour
{
    [SerializeField] private int damage = 1; //��ֹ��� �ִ� ������

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //��ֹ����� �ε��� ������Ʈ �±װ� "Player"���
        if (collision.CompareTag("Player"))
        {
            //��ֹ� ��������ŭ �÷��̾� life����
            collision.GetComponent<PlayerLife>().TakeDamage(damage);
            //��ֹ��� ����
            Destroy(gameObject);
        }
    }
}

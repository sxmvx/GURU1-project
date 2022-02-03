using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    //�ʿ�Ӽ� : �̵��ӵ�
    public float speed = 5;
    // ������ ���������� ���� Start�� Update���� ���
    Vector3 dir;
    
   

    void Start()
    {
       
        // 0���� 9(10-1) ���� ���߿� �ϳ��� �������� �����ͼ�
        int randValue = UnityEngine.Random.Range(0, 10);
        // ���� 3���� ������ �÷��̾����
        if (randValue < 3)
        {
            // �÷��̾ ã�Ƽ� target���� �ϰ�ʹ�.
            GameObject target = GameObject.Find("Player");
            // ������ ���ϰ�ʹ�. target - me
            dir = target.transform.position - transform.position;
            // ������ ũ�⸦ 1�� �ϰ� �ʹ�.
            dir.Normalize();
        }
        // �׷��� ������ �Ʒ��������� ���ϰ� �ʹ�.
        else
        {
            dir = Vector3.left;
        }
    }

    void Update()
    {
        
        // 2. �̵��ϰ� �ʹ�. ���� P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
   
    // �浹 ����
    private void OnCollisionEnter(Collision other)
    {
       
            // ���װ�
            Destroy(other.gameObject);
            // ������
            Destroy(gameObject);
       
    }
}

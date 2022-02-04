using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.0f;
    Vector3 moveDirection;
    

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    void Start()
    {
        // 0���� 9(10-1) ���� ���߿� �ϳ��� �������� ������
        int randValue = UnityEngine.Random.Range(0, 10);
        // ���� 3���� ������ �÷��̾����
        if (randValue < 3)
        {
            // �÷��̾ ã�Ƽ� target���� ����
            GameObject target = GameObject.Find("Player");
            // ������ ���ϱ� target - me
            moveDirection = target.transform.position - transform.position;
            // ������ ũ�⸦ 1
            moveDirection.Normalize();
        }
        // �׷��� ������ ���ʹ������� �̵�
        else
        {
            moveDirection=Vector3.left;
        }
    }
    
}

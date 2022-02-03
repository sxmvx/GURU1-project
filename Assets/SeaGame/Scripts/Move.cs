using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.0f;
    Vector3 moveDirection;
    

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

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
            moveDirection = target.transform.position - transform.position;
            // ������ ũ�⸦ 1�� �ϰ� �ʹ�.
            moveDirection.Normalize();
        }
        // �׷��� ������ �Ʒ��������� ���ϰ� �ʹ�.
        else
        {
            moveDirection=Vector3.left;
        }
    }
    
}

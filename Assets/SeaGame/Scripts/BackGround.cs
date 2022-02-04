using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float scrollRange = 17.93f;
    [SerializeField] private float moveSpeed = 3.0f;
    [SerializeField] private Vector3 moveDirection = Vector3.left;

    //������ ����Ǵ� ���� ��� �ϰ� �ʹ�.
    private void Update()
    {
        //����� moveDirection�������� moveSpeed�ӵ��� �̵�
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
        //����� ������ ������ ����� ��ġ �缳��
        if(transform.position.x<=-scrollRange)
        {
            transform.position = target.position + Vector3.right * scrollRange;
        }
       
    }

}

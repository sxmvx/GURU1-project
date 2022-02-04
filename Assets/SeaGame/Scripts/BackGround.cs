using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float scrollRange = 17.93f;
    [SerializeField] private float moveSpeed = 3.0f;
    [SerializeField] private Vector3 moveDirection = Vector3.left;

    //게임이 진행되는 동안 계속 하고 싶다.
    private void Update()
    {
        //배경이 moveDirection방향으로 moveSpeed속도로 이동
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
        //배경이 설정된 범위를 벗어나면 위치 재설정
        if(transform.position.x<=-scrollRange)
        {
            transform.position = target.position + Vector3.right * scrollRange;
        }
       
    }

}

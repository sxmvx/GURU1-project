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
        // 0부터 9(10-1) 까지 값중에 하나를 랜덤으로 가져옴
        int randValue = UnityEngine.Random.Range(0, 10);
        // 만약 3보다 작으면 플레이어방향
        if (randValue < 3)
        {
            // 플레이어를 찾아서 target으로 설정
            GameObject target = GameObject.Find("Player");
            // 방향을 구하기 target - me
            moveDirection = target.transform.position - transform.position;
            // 방향의 크기를 1
            moveDirection.Normalize();
        }
        // 그렇지 않으면 왼쪽방향으로 이동
        else
        {
            moveDirection=Vector3.left;
        }
    }
    
}

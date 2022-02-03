using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacletrigger : MonoBehaviour
{
    [SerializeField] private int damage = 1; //장애물이 주는 데미지

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //장애물에게 부딪힌 오브젝트 태그가 "Player"라면
        if (collision.CompareTag("Player"))
        {
            //장애물 데미지만큼 플레이어 life감소
            collision.GetComponent<PlayerLife>().TakeDamage(damage);
            //장애물이 죽음
            Destroy(gameObject);
        }
    }
}

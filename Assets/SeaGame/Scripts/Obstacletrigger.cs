using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacletrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //적에게 부딪힌 오브젝트 태그가 "Player"라면
        if (collision.CompareTag("Player"))
        {
            //적이 죽음
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayerMove : MonoBehaviour
{
    // �÷��̾ �̵� �ӷ�
    public float speed = 5;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, v, 0);
        // P = P0 + vt �������� ����
        transform.position += dir * speed * Time.deltaTime;
    }

}

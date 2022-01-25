using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    public float speedRun;
    public float h, v;
    Vector3 dir;

    public int walkCount;
    private int currentWalkCount;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedRun = 10;
        }
        else
            speedRun = 0;

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        dir = new Vector3(h, v, 0);

        transform.position += dir * (speed + speedRun) * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_1 : MonoBehaviour
{
    public float speed;
    public float speedRun;
    private float applyRunSpeed;
    private bool applyRunFlag = false;

    private Vector3 vector;

    public int walkCount;
    private int currentWalkCount;

    void Start()
    {
    }

    IEnumerator MoveCoroutine()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            applyRunSpeed = speedRun;
            applyRunFlag = true;
        }
        else
        {
            applyRunSpeed = 0;
            applyRunFlag = false;
        }

        vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);

        while (currentWalkCount < walkCount)
        {
            if (vector.x != 0)
            {
                transform.Translate(vector.x * (speed + applyRunSpeed), 0, 0);
            }
            else if (vector.y != 0)
            {
                transform.Translate(0, vector.y * (speed + applyRunSpeed), 0);
            }
            if (applyRunFlag)
                currentWalkCount++;
            currentWalkCount++;
            yield return new WaitForSeconds(0.01f);
        }
        currentWalkCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                StartCoroutine(MoveCoroutine());
            }
        
    }
}


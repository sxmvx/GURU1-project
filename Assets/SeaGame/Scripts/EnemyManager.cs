using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // ����ð�
    float currentTime;
    // �����ð�
    public float createTime = 1;
    // �� ����
    public GameObject enemyFactory;
    // �ּҽð�
    float minTime = 1;
    // �ִ�ð�
    float maxTime = 5;


    void Start()
    {
        // �¾ �� �� �����ð��� �����ϰ�
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }


    
    void Update()
    {
        // 1. �ð��� �帣�ٰ�
        currentTime += Time.deltaTime;
        // 2. ���� ����ð��� �����ð��� �Ǹ�
        if (currentTime > createTime)
        {
            // 3. �� ���忡�� ���� �����ؼ�
            GameObject enemy = Instantiate(enemyFactory);
            // �� ��ġ�� ���� ���� �ʹ�.
            enemy.transform.position = transform.position;
            // ����ð��� 0���� �ʱ�ȭ
            currentTime = 0;
            // ���� ������ �� �� �����ð��� �ٽ� �����ϰ� �ʹ�.
            createTime = UnityEngine.Random.Range(minTime, maxTime);

        }
    }
}

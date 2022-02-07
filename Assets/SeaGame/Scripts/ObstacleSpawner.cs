using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private StageData stageData;
    [SerializeField] private GameObject Obstacle;
    [SerializeField] private float spawnTime;

    private void Awake()
    {
        StartCoroutine("SpawnObstacle");
    }

   private IEnumerator SpawnObstacle()
    {
        while (true)
        {
            //y��ġ �������� ũ�� ���� �ȿ��� ������ �� ����
            float positionX = Random.Range(stageData.LimitMin.y, stageData.LimitMax.y-1.0f);
            //��ֹ� ����
            Instantiate(Obstacle, new Vector3(stageData.LimitMax.x + 1.0f, positionX, 0.0f), Quaternion.identity);
            //spawnTime��ŭ ���
            yield return new WaitForSeconds(spawnTime);
        }
    }

    
   
}

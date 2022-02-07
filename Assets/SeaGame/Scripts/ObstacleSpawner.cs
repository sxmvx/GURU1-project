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
            //y위치 스테이지 크기 범위 안에서 임의의 값 선택
            float positionX = Random.Range(stageData.LimitMin.y, stageData.LimitMax.y-1.0f);
            //장애물 생성
            Instantiate(Obstacle, new Vector3(stageData.LimitMax.x + 1.0f, positionX, 0.0f), Quaternion.identity);
            //spawnTime만큼 대기
            yield return new WaitForSeconds(spawnTime);
        }
    }

    
   
}

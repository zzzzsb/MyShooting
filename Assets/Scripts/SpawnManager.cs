using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간마다 적생성기를 선택해서 그 적성기에게 적을 생성하라고 명령하고 싶다.
// 적생성기리스트
// 현재시간
// 일정시간(생성시간)
public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyManager[] enemyArray;
    float currentTime;
    float createTime;
    public float minCreateTime=1;
    public float maxCreateTime=3;
    void Start()
    {
        createTime = UnityEngine.Random.Range(minCreateTime, maxCreateTime);
    }

    // Update is called once per frame
    void Update()
    {
        //현재시간이 흐르다가
        currentTime += Time.deltaTime;
        //생성시간이 되면
        if(currentTime > createTime)
        {
            currentTime = 0;
            //적을 생성하라고 명령
            CreateEnemys();

        }


    }
    private void CreateEnemys()
    {
        // 랜덤으로 적생성기중에 하나를 골라서

        // 적을 생성하고 싶다.
    }
}

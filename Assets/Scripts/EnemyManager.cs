using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 현재 시간이 흐르다가
// 현재시간이 생성시간이 되면
// 적공장에서 적을 생성한다.

// 현재시간
// 생성시간
// 적공장
public class EnemyManager : MonoBehaviour
{
    float currentTime;
    float createTime;
    public float minCreateTime = 1;
    public float maxCreateTime = 3;

    public GameObject[] enemyFactory;
    // Start is called before the first frame update
    void Start()
    {
        createTime = Random.Range(minCreateTime, maxCreateTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > createTime)
        {
            int rIndex = Random.Range(0, enemyFactory.Length);
            GameObject enemy = Instantiate(enemyFactory[rIndex]);
            enemy.transform.position = transform.position;
            currentTime = 0;
            createTime = Random.Range(minCreateTime, maxCreateTime);
        }
    }


}

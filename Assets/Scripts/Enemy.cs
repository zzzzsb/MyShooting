using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 적은 태어나고 생성될때 자신의 방향을 정하는데
// 30퍼센트 확률로 플레이어쪽을 향하게 한다
// 나머지는 아래를 향하게 한다
// 방향에 따라 움직인다.

// 속도
// 방향
public class Enemy : MonoBehaviour
{
    public float speed = 3;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0, 100) < 30)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}

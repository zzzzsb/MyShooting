using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public float speed = 2;
    Vector3 dir;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0, 100) < 40)
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

    private void OnCollisionEnter(Collision other)
    {
        count++;
        //플레이어의 총알을 세번 맞으면
        if(count == 3)
        {
            //죽는다.
            Destroy(gameObject);
        }
    }
}

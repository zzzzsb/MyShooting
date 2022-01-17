using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject enemyBulletFactory;
    public GameObject EnemyfirePosition;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Fire", 0.7f);
    }

    void Fire()
    {
        GameObject enemyBullet = Instantiate(enemyBulletFactory);
        enemyBullet.transform.position = EnemyfirePosition.transform.position;
        GameObject target = GameObject.Find("Player");
        Vector3 dir = target.transform.position - transform.position;
        dir.Normalize();

        //enemyBullet.transform.up = dir;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

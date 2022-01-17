using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자가 마우스 왼쪽 버튼을 누르면
// 총알공장에서 총알을 생성하여
// 총알위치를 총구에 가져다 대고싶다.
// 총알공장
// 총구위치
public class PlayerFire : MonoBehaviour
{
    public GameObject playerBulletFactory;
    public GameObject playerfirePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject playerBullet = Instantiate(playerBulletFactory);
            playerBullet.transform.position = playerfirePosition.transform.position;
        }
    }
}

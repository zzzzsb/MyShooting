using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

//플레이어의 목숨을 5개로!
public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    public int maxHP = 5;
    public Text hpText;
    int curHp;
    
    public int HP
    {
        get { return curHp; }
        set { curHp = value;
            hpText.text = "HP " + curHp;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        hpText.text = "HP" + maxHP;
        HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        dir.Normalize();
        transform.Translate(dir * speed * Time.deltaTime);

        LimitScreen();

    }

    private void LimitScreen()
    {
        Vector3 vPos = Camera.main.WorldToViewportPoint(transform.position);
        vPos.x = Mathf.Clamp01(vPos.x);
        vPos.y = Mathf.Clamp01(vPos.y);
        transform.position = Camera.main.ViewportToWorldPoint(vPos);

    }
}

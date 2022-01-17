using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        //Destroy(other.gameObject);
        //print(other.gameObject.name);
        if (other.gameObject.name.Contains("Player"))
        {
            PlayerMove pm = other.gameObject.GetComponent<PlayerMove>();
            pm.HP--;
            if(pm.HP <= 0)
            {
                GameManager gm = GameObject.FindObjectOfType<GameManager>();
                if(gm != null)
                {
                    gm.gameOverUI.SetActive(true);
                }
                Destroy(other.gameObject);
            }
        }
        Destroy(gameObject);
    }
}

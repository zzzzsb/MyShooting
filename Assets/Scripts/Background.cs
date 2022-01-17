using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 배경을 위에서 아래로 스크롤
public class Background : MonoBehaviour
{
    public float speed = 0.2f;
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float newOffsetY = mat.mainTextureOffset.y + speed * Time.deltaTime;
        Vector2 newOffset = new Vector2(0, newOffsetY);

        mat.mainTextureOffset = newOffset;
    }
}

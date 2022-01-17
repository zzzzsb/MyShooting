using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DestroyZone과 부딪히면 죽는다.

public class DestroyZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //print(other.gameObject.name);
        //Destroy(other.gameObject);
    }
}

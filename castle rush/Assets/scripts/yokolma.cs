using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokolma : MonoBehaviour
{
    public float olmezaman = 5;
    void Start()
    {
        if (transform.position.y > -2) { Destroy(gameObject, olmezaman); }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

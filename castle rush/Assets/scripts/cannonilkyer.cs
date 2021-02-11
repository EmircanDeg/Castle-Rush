using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonilkyer : MonoBehaviour
{
    public float x;
    public float y=-0.07f;
    public float eksiz = 0;
    void Start()
    {
        if (transform.position.y > -2) { transform.position = new Vector3(x, y, transform.position.z-eksiz); }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

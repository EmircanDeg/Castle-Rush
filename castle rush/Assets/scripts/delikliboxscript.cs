using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delikliboxscript : MonoBehaviour
{
    public float range = 9;
    void Start()
    {
        if (transform.position.y > -2) { transform.position = new Vector3(Random.Range(-range, range), 0.85f, transform.position.z); }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agacscrpit : MonoBehaviour
{
    // Start is called before the first frame update
    public float hiz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -2) {
            transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime * hiz;
            if (transform.position.z < -38) { Destroy(gameObject); }
        }
        
    }
}

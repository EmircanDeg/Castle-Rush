using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        rigid.AddForce(0, 1000, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodykapama : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        rigid.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -1) { rigid.isKinematic = false; }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okkirilma : MonoBehaviour
{
    public GameObject kirikok;
    Rigidbody rigid;
    public float hiz;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = new Vector3(1, 0, 0) * hiz;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kalkan") { Instantiate(kirikok, transform.position, transform.rotation);Destroy(gameObject); }
    }
    void Update()
    {
        
    }
}

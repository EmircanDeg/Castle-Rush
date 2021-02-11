using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskirilma : MonoBehaviour
{
    public GameObject kiriktas;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "olum") { Instantiate(kiriktas, transform.position, transform.rotation);Destroy(gameObject); }
    }
    void Update()
    {
        
    }
}

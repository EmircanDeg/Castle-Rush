using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satinalmasandik : MonoBehaviour
{
    public GameObject efekt;
    public Vector3 vektor;
    public float xfarki;
    public float zaman;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "rampa") { Instantiate(efekt, vektor, transform.rotation);Invoke("efektcikarma", zaman); }
    }

    void efektcikarma() { Instantiate(efekt, vektor-new Vector3(xfarki,0,0), transform.rotation); }
    void Update()
    {
        
    }
}

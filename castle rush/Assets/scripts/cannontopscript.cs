using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannontopscript : MonoBehaviour
{
    Rigidbody rigid;
    public float hiz;
    public GameObject kiriktop;
    public bool solmu = false;
    public AudioSource kanonkirilma;
    public bool tutorial = false;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = new Vector3(1, 0, 0) * hiz;
    }

    private void OnMouseDown()
    {
        kanonkirilma.Play();
        Instantiate(kiriktop, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if(tutorial == false) {
            if (solmu == false) { transform.Rotate(0, 0, 2); }
            if (solmu == true) { transform.Rotate(0, 0, -2); }
        }

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baltasallanma : MonoBehaviour
{
    float hiz = 1;
    public bool donum = false;
    public bool kamera = false;
    public bool tutorial = false;
    void Start()
    {
        hiz = Random.Range(1, 2.5f);
        if (kamera == true) { hiz = 0.3f; }
        if (tutorial == true) { hiz = 0.7f; }
    }

    // Update is called once per frame
    void Update()
    {
        if (donum == false) { transform.Rotate(0, hiz, 0); }
        if (donum == true) { transform.Rotate(0, -hiz, 0); }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kalkan") { hiz = -hiz; }
    }
}

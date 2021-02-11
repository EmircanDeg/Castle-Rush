using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kilicscript : MonoBehaviour
{
    public GameObject kiliclar;
    bool oldu = false;
    public float y;
    public float hiz;
    public AudioSource inme;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") { if (oldu == false) { inme.Play(); } oldu = true; }
    }
    private void OnMouseDown()
    {
        if (oldu == false) { inme.Play(); }
        oldu = true;;
    }
    void Update()
    {
        if(oldu == true)
        {
            if (transform.position.y > y-0.25f) { transform.position = transform.position + new Vector3(0, 1, 0) * (hiz/5) * Time.deltaTime; }
            if (kiliclar.transform.position.y > y) { kiliclar.transform.position = kiliclar.transform.position + new Vector3(0, 1, 0) * hiz * Time.deltaTime; }
        }
        
    }
}

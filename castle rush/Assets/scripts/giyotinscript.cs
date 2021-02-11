using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giyotinscript : MonoBehaviour
{
    public float hiz = 1;
    public float asagi;
    public float yukari;
    public GameObject kirikgiyot;
    bool degdi = false;
    public AudioSource kirilis;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -2)
        {
            if (degdi == false) { transform.position = transform.position + new Vector3(0, -1, 0) * Time.deltaTime * hiz * 3; }
            if (degdi == true) { transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime * hiz; }
            if (transform.position.y > yukari) { degdi = false; }
            if (transform.position.y < asagi) { degdi = true; }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kalkan") { Instantiate(kirikgiyot, transform.position, transform.rotation);kirilis.Play() ;Destroy(gameObject); }
        
    }
}

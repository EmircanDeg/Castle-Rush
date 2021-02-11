using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatekalkma : MonoBehaviour
{
    bool basildi = false;
    public float hiz;
    public AudioSource kalkma;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(basildi == true)
        {
            if (transform.position.y < 2.2f) { transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime * hiz; }
        }
    }

    private void OnMouseDown()
    {
        kalkma.Play();
        basildi = true;
    }
}

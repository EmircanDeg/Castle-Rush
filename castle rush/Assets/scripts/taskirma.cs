using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskirma : MonoBehaviour
{
    public GameObject kiriktas;
    public AudioSource taskir;
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Instantiate(kiriktas, transform.position, transform.rotation);
        taskir.Play();
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
}

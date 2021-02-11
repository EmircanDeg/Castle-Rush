using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapitutucuscript : MonoBehaviour
{
    public GameObject kapi;
    public GameObject kirik;
    public float x;
    public AudioSource kiirlmatahat;
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        kapi.GetComponent<dusenkapiscript>().sayici();
        Instantiate(kirik, transform.position-new Vector3(x,0,0), kirik.transform.rotation);
        kiirlmatahat.Play();
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
}

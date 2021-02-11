using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baltascript : MonoBehaviour
{
    public GameObject kirik;
    public GameObject balta;
    public AudioSource kirilmases;
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
         Instantiate(kirik, balta.transform.position, balta.transform.rotation);kirilmases.Play(); Destroy(gameObject);
    }
    void Update()
    {
        
    }
}

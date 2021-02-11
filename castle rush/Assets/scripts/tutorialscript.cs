using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialscript : MonoBehaviour
{
    public GameObject tutoekran;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") { tutoekran.SetActive(true); }
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") { tutoekran.SetActive(true); }
    }*/
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agaccikarici : MonoBehaviour
{
    public GameObject agac;
    float sayac=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sayac = sayac + Time.deltaTime;
        if (sayac > 1.5) { Instantiate(agac, transform.position, transform.rotation);sayac = 0; }
    }
}

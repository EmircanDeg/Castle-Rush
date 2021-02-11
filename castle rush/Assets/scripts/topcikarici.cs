using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topcikarici : MonoBehaviour
{
    public GameObject top;
    float sayac=0;
    public float limit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sayac = sayac + Time.deltaTime;
        if (sayac > limit) { Instantiate(top, transform.position, transform.rotation);sayac = 0; }
    }
}

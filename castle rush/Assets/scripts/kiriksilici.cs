﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kiriksilici : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kirik") { Destroy(other.gameObject); }
    }
    void Update()
    {
        
    }
}

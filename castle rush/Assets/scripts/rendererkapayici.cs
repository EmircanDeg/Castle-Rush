using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rendererkapayici : MonoBehaviour
{
    bool bak = false;
    void Start()
    {
        if (transform.position.y < -2) { gameObject.GetComponent<MeshRenderer>().enabled = false; }
    }

    // Update is called once per frame
    void Update()
    {
        if(bak == false)
        {
            if (transform.position.y > -2) { gameObject.GetComponent<MeshRenderer>().enabled = true;bak = true; }
        }
    }
}

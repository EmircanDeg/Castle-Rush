using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokedici : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
    void Update()
    {
        
    }
}

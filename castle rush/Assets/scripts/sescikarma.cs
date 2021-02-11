using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sescikarma : MonoBehaviour
{
    public AudioSource ses;
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        ses.Play();
    }
    void Update()
    {
        
    }
}

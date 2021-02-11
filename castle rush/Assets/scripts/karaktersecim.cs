using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karaktersecim : MonoBehaviour
{
    public int secim;
    void Start()
    {
        if(PlayerPrefs.GetInt("karaktersecim")!= secim) { gameObject.SetActive(false); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

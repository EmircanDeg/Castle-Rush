using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsecim : MonoBehaviour
{
    public int itemsec;
    void Start()
    {
       
        if(PlayerPrefs.GetInt("itemsec") != itemsec) { gameObject.SetActive(false); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secimgorunmeitem : MonoBehaviour
{
    public int itemgor;
    void Start()
    {
        if (itemgor != 0) {
            if (PlayerPrefs.GetInt("secimgorunmeitem") != itemgor) { gameObject.GetComponent<MeshRenderer>().enabled = false; }
            if (PlayerPrefs.GetInt("secimgorunmeitem") == itemgor) { gameObject.GetComponent<MeshRenderer>().enabled = true; }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (itemgor != 0)
        {
            if (PlayerPrefs.GetInt("secimgorunmeitem") != itemgor) { gameObject.GetComponent<MeshRenderer>().enabled = false; }
            if (PlayerPrefs.GetInt("secimgorunmeitem") == itemgor) { gameObject.GetComponent<MeshRenderer>().enabled = true; }
        }
    }
}

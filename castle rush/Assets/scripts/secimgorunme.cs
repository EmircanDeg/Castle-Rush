using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secimgorunme : MonoBehaviour
{
    public int secimgor;
    public GameObject itemler;
    Vector3 esasyer;
    void Start()
    {
        gameObject.GetComponent<Animator>().speed = 0.5f;
        esasyer = transform.position;
        if (PlayerPrefs.GetInt("secimgorunme") != secimgor) { transform.position = new Vector3(0, 500, 0);itemler.SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == secimgor) { transform.position = esasyer;itemler.SetActive(true); }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("secimgorunme") != secimgor) { transform.position = new Vector3(0, 500, 0);itemler.SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == secimgor) { transform.position = esasyer;itemler.SetActive(true); }
    }
}

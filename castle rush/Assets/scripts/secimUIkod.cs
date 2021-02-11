using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class secimUIkod : MonoBehaviour
{
    public AudioSource ses;
    public AudioSource selectses;
    public GameObject secimefekt;
    void Start()
    {
        
    }

    public void ileri()
    {
        ses.Play();
        if (PlayerPrefs.GetInt("secimgorunme") == 30) { PlayerPrefs.SetInt("secimgorunme", 0); }
        else { PlayerPrefs.SetInt("secimgorunme", PlayerPrefs.GetInt("secimgorunme") + 1); }
    }
    public void geri()
    {
        ses.Play();
        if (PlayerPrefs.GetInt("secimgorunme") == 0) { PlayerPrefs.SetInt("secimgorunme", 30); }
        else { PlayerPrefs.SetInt("secimgorunme", PlayerPrefs.GetInt("secimgorunme") - 1); }
    }

    public void ileriitem() 
    {
        ses.Play();
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 24) { PlayerPrefs.SetInt("secimgorunmeitem", 0); }
        else { PlayerPrefs.SetInt("secimgorunmeitem", PlayerPrefs.GetInt("secimgorunmeitem") + 1); }
    }

    public void geriitem() 
    {
        ses.Play();
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 0) { PlayerPrefs.SetInt("secimgorunmeitem", 24); }
        else { PlayerPrefs.SetInt("secimgorunmeitem", PlayerPrefs.GetInt("secimgorunmeitem") - 1); }
    }

    public void karaktersecme() { PlayerPrefs.SetInt("karaktersecim", PlayerPrefs.GetInt("secimgorunme")); selectses.Play();Instantiate(secimefekt, new Vector3(0, 2.4f, -0.3f), transform.rotation); }

    public void itemsecme() { PlayerPrefs.SetInt("itemsec", PlayerPrefs.GetInt("secimgorunmeitem"));selectses.Play(); Instantiate(secimefekt, new Vector3(0, 2.4f, -0.3f), transform.rotation); }

    public void homeagit() { SceneManager.LoadScene("home"); }

    public void satinalmagit() { SceneManager.LoadScene("satinalma"); }
    void Update()
    {
        
    }
}

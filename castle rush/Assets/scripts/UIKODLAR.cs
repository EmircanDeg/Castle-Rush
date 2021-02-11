using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIKODLAR : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject pausemenu;
    public GameObject[] pausebutonlar;
    float hiz;
    bool durdu = false;
    Vector3 vektor;
    public bool homeekran = false;
    public GameObject sesacbuton;
    public GameObject seskapabuton;
    public AudioSource ses1;
    public GameObject paratext;
    public GameObject higskortext;
    public GameObject okresim;
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("highscore"));
        if (PlayerPrefs.GetInt("ses") == 1) { AudioListener.pause = true; if (homeekran == true) { sesacbuton.SetActive(true); seskapabuton.SetActive(false); } }
        if (PlayerPrefs.GetInt("ses") == 0) { AudioListener.pause = false; if (homeekran == true) { sesacbuton.SetActive(false); seskapabuton.SetActive(true); } }
        if (homeekran == false) { hiz = player.GetComponent<playerhareket>().hiz; }
        if (PlayerPrefs.GetInt("okresim") == 1) { okresim.SetActive(false); }
        if(homeekran == true) { paratext.GetComponent<Text>().text = PlayerPrefs.GetInt("para").ToString();higskortext.GetComponent<Text>().text = PlayerPrefs.GetInt("highscore").ToString(); }
        
    }

    public void start()
    { 
        if (PlayerPrefs.GetInt("tutorialgit") == 0) { PlayerPrefs.SetInt("tutorialgit", 1); SceneManager.LoadScene("tutorial"); } 
        else { PlayerPrefs.SetInt("tutorialgit", 1); SceneManager.LoadScene("oyun"); } 
    }
    public void kontinue() { player.GetComponent<playerhareket>().hiz = hiz;pausemenu.SetActive(false); pausebutonlar[1].SetActive(false); pausebutonlar[0].SetActive(true);durdu = false; player.GetComponent<playerhareket>().kosuses.Play();ses1.Play(); }
    
    public void home() { SceneManager.LoadScene("home"); }

    public void exit() { Application.Quit(); }

    public void pause() { player.GetComponent<playerhareket>().hiz = 0;vektor = player.transform.position;durdu=true ; player.GetComponent<Rigidbody>().velocity = Vector3.zero ; pausemenu.SetActive(true); pausebutonlar[0].SetActive(false);pausebutonlar[1].SetActive(true);player.GetComponent<playerhareket>().kosuses.Stop();ses1.Play(); }

    public void skinalmascene() { SceneManager.LoadScene("skinalma"); }

    public void satinalmagit() { if (PlayerPrefs.GetInt("okresim") == 0) { PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") + 5000); } PlayerPrefs.SetInt("okresim",1); SceneManager.LoadScene("satinalma"); }

    public void sesac() { PlayerPrefs.SetInt("ses", 0); seskontrol(); }
    public void seskapa() { PlayerPrefs.SetInt("ses", 1);seskontrol(); }
    public void seskontrol()
    {
        if (PlayerPrefs.GetInt("ses") == 1) { AudioListener.pause = true;if (homeekran == true) { sesacbuton.SetActive(true); seskapabuton.SetActive(false); }  }
        if (PlayerPrefs.GetInt("ses") == 0) { AudioListener.pause = false;if (homeekran == true) { sesacbuton.SetActive(false); seskapabuton.SetActive(true); }  }
    }

    public void tutorialgit() { SceneManager.LoadScene("tutorial"); }
   
    void Update()
    {
        if(durdu == true) { player.transform.position = vektor; }
        
    }

}

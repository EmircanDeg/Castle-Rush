using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class girisgecme : MonoBehaviour
{
    public GameObject arka;
    Color lerpedColor = new Color32(255, 255, 255, 255);
    Color soncolor = new Color32(225,75,26,255);
    //Color soncolor = new Color32(243, 154, 19, 255);
    void Start()
    {
        Invoke("home", 3);
        arka.GetComponent<Image>().color = lerpedColor;
    }
    public void home() { SceneManager.LoadScene("home"); }
    // Update is called once per frame
    void Update()
    {
        lerpedColor = Color.Lerp(lerpedColor, soncolor, Mathf.PingPong(Time.time, 0.02f));
        arka.GetComponent<Image>().color = lerpedColor;
    }
}

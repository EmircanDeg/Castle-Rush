using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerhareket : MonoBehaviour
{
    public float hiz = 1;
    float rampahiz;
    float esashiz;
    public GameObject summoncu;
    public int puan = 0;
    public GameObject puantext;
    public GameObject paratext;
    Rigidbody rigid;
    public int sandikpara = 0;
    public GameObject gameoverekran;
    public GameObject kosmaefekt;
    public GameObject olmeefekt;
    public GameObject karakterler;
    public int kazanilanpara = 0;
    public GameObject sandikparatext;
    public GameObject puanparatext;
    public GameObject puantext2;
    public GameObject kazanilanparatext;
    public GameObject pausebuton;
    public AudioSource kosuses;
    public AudioSource olmeses;
    bool hizart = false;
    bool degdi = false;
    public GameObject newhighskorimaj;
    void Start()
    {
        rampahiz = hiz + 7;
        esashiz = hiz;
        rigid = gameObject.GetComponent<Rigidbody>();
        puantext.GetComponent<Text>().text="0";
        paratext.GetComponent<Text>().text = PlayerPrefs.GetInt("para").ToString();
        kosuses.Play();
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0, 0, 1) * hiz * Time.deltaTime;
        transform.position = new Vector3(0, transform.position.y, transform.position.z);
        //transform.Rotate(hiz, 0, 0);

    }
    void Update()
    {
        //if (transform.position.y < 0.5f) { transform.position = new Vector3(transform.position.x,0.5f,transform.position.z); }
        if (puan != 0) { if (puan % 100 == 0) { hizart = true; } }
        if (degdi == true) { if (hizart == true) { esashiz=esashiz+0.05f; hizart = false; Debug.Log("HIZ = " + hiz);degdi = false; } }
        //if(hizart == true) { hiz = hiz + .1f;rampahiz = hiz + 7;esashiz=hiz ;hizart = false;Debug.Log("HIZ = " + hiz);puan = puan + 10; }
        if (transform.position.y== 0.5f) { rigid.velocity = Vector3.zero; }
        //rigid.velocity = Vector3.zero;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cikis") { hiz = esashiz; }
        if (other.gameObject.tag == "summontetik") { degdi = true; summoncu.GetComponent<summoncu>().summon(); puan = puan + 10; puantext.GetComponent<Text>().text =puan.ToString() ;Destroy(other.gameObject);  if (puan > PlayerPrefs.GetInt("highscore")) { PlayerPrefs.SetInt("highscore", puan);newhighskorimaj.SetActive(true); } }
        if (other.gameObject.tag == "olum") { kosuses.Stop(); olmeses.Play(); hiz = 0; gameObject.GetComponent<Rigidbody>().isKinematic = true; karakterler.SetActive(false); kosmaefekt.SetActive(false); gameObject.GetComponent<SphereCollider>().enabled = false; Instantiate(olmeefekt, transform.position - new Vector3(0, -2, 1), transform.rotation); pausebuton.SetActive(false); Invoke("gameovergelme", 2.5f); }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "yer") { hiz = esashiz; }
        if (collision.gameObject.tag == "yarirampa") { hiz = rampahiz - 6; }
        if (collision.gameObject.tag == "rampa") { hiz = rampahiz; }
        
        if (collision.gameObject.tag == "olum") {kosuses.Stop(); olmeses.Play(); hiz = 0;gameObject.GetComponent<Rigidbody>().isKinematic = true;karakterler.SetActive(false);kosmaefekt.SetActive(false);gameObject.GetComponent<SphereCollider>().enabled = false ; Instantiate(olmeefekt, transform.position-new Vector3(0,-2,1), transform.rotation); pausebuton.SetActive(false); Invoke("gameovergelme", 2.5f); }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "rampa") { hiz = esashiz; }
        if (collision.gameObject.tag == "yarirampa") { hiz = esashiz; ; }
    }

    void gameovergelme() { gameoverekran.SetActive(true);puantext2.GetComponent<Text>().text = puan.ToString();sandikparatext.GetComponent<Text>().text = sandikpara.ToString();puanparatext.GetComponent<Text>().text = (puan / 10).ToString();kazanilanpara = (puan / 10) + sandikpara;kazanilanparatext.GetComponent<Text>().text = kazanilanpara.ToString();paraekleme(); }
    public void paraekleme() { PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") + kazanilanpara); }
}

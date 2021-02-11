using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sandikscript : MonoBehaviour
{
    public float range = 9;
    public GameObject kiriksandik;
    public GameObject coin;
    public int secim;
    public GameObject player;
    public AudioSource ses;
    public AudioSource ses1;
    
    void Start()
    {
        if (transform.position.y > -2) { transform.position = new Vector3(Random.Range(-range, range), 2f, transform.position.z-4f); }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ses.Play();
            ses1.Play();
            if(secim == 0) { player.GetComponent<playerhareket>().sandikpara = player.GetComponent<playerhareket>().sandikpara + 10; }
            if (secim == 1) { player.GetComponent<playerhareket>().sandikpara = player.GetComponent<playerhareket>().sandikpara + 50; }
            if (secim == 2) { player.GetComponent<playerhareket>().sandikpara = player.GetComponent<playerhareket>().sandikpara + 100; }
            
            Instantiate(kiriksandik, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }
}

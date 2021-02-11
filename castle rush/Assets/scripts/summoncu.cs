using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summoncu : MonoBehaviour
{
    public GameObject[] cikacaklar;
    public GameObject summontetik;
    public GameObject[] sandiklar;
    int random;
    int randomsandik;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void summon() {
        random = Random.Range(0, cikacaklar.Length);
        Instantiate(cikacaklar[random], transform.position, cikacaklar[random].transform.rotation);
        randomsandik = Random.Range(0, sandiklar.Length);
        Instantiate(sandiklar[randomsandik], transform.position, sandiklar[randomsandik].transform.rotation);
        Instantiate(summontetik, transform.position, summontetik.transform.rotation);
    }
}

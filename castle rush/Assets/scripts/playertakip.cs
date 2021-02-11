using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertakip : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public float y = 0;
    public bool karakter = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, transform.position.y, player.transform.position.z-distance);
        if (karakter == true) { transform.position = new Vector3(0, player.transform.position.y-y, player.transform.position.z - distance); }
    }
}

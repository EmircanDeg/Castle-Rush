using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okilerleme : MonoBehaviour
{
    public GameObject player;
    float hiz;
    void Start()
    {
        hiz = player.GetComponent<playerhareket>().hiz;
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0, 0, 1) * hiz * Time.deltaTime;
        transform.Rotate(0, 0, 5);
    }
    void Update()
    {
        
    }
}

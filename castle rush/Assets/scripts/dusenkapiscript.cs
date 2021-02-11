using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusenkapiscript : MonoBehaviour
{
    int say = 0;
    public GameObject yokolacak;
    bool oldu = false;
    public AudioSource carpma;
    void Start()
    {
        
    }

    public void sayici() { say = say + 1; }
    void Update()
    {
        if (say == 2) { transform.Rotate(2f, 0, 0);yoketme();oldu = true; }
    }

    void yoketme() { if (oldu == false) { Destroy(yokolacak); } }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kalkan") {carpma.Play(); sayici(); }
    }
}

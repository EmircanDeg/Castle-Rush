using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suruklemehareket : MonoBehaviour
{
    private Vector3 mouspozisyonu;
    private Vector3 pos;
    private Vector3 ilkPos;
    bool basma;
    float dist = 20;
    public float y;
    public GameObject kamera;
    private void Start()
    {
        kamera = GameObject.Find("Main Camera");
    }
    private void OnMouseDown()
    {
        dist = transform.position.z - kamera.transform.position.z+3;
        if (Input.GetMouseButtonDown(0))
        {
            mouspozisyonu = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            ilkPos = Camera.main.ScreenToWorldPoint(mouspozisyonu) - transform.position;
        }
        basma = true;
    }
    private void OnMouseDrag()
    {
        mouspozisyonu = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
        pos = Camera.main.ScreenToWorldPoint(mouspozisyonu);
        if (basma)
            transform.position = new Vector3(pos.x - ilkPos.x, transform.position.y, transform.position.z); //pos - initialPos;
    }
    private void OnMouseUp()
    {
        basma = false;
    }
}

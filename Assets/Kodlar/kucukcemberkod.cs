using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcemberkod : MonoBehaviour {
    Rigidbody2D fizik;
    public float hiz;
    bool hareketkontrol = false;
    GameObject oyunYoneticisi;
	// Use this for initialization
	void Start () {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!hareketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="donencembertag")
        {
            transform.SetParent(col.transform);
            hareketkontrol = true;
        }
        if (col.tag=="kucukcembertag")
        {
            oyunYoneticisi.GetComponent<oyunyoneticisikod>().oyunBitti();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class btnKod : MonoBehaviour
{
    GameObject donenCember1;
    GameObject AnaCember1;
    public Text duraklat;
    bool durduMu = false;
    // Use this for initialization
    void Start()
    {
        donenCember1 = GameObject.FindGameObjectWithTag("donencembertag");
        AnaCember1 = GameObject.FindGameObjectWithTag("anacembertag");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Geri()
    {
        SceneManager.LoadScene("AnaMenu");
    }

    public void Duraklat()
    {
        if (!durduMu)
        {
            donenCember1.GetComponent<dondurme>().enabled = durduMu;
            AnaCember1.GetComponent<anacemberkod>().enabled = durduMu;
            durduMu = true;
            duraklat.text = "Devam Et";
        }
        else
        {
            donenCember1.GetComponent<dondurme>().enabled = durduMu;
            AnaCember1.GetComponent<anacemberkod>().enabled = durduMu;
            durduMu = false;
            duraklat.text = "Duraklat";
        }

    }
}

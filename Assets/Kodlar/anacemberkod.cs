using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class anacemberkod : MonoBehaviour
{
    int okSayisi;
    public Text bir, iki, uc, levelText;
    public GameObject kusuckCember;
    GameObject donenCember, AnaCember;
    // Use this for initialization
    void Start()
    {
        donenCember = GameObject.FindGameObjectWithTag("donencembertag");
        AnaCember = GameObject.FindGameObjectWithTag("anacembertag");
        okSayisi = int.Parse(SceneManager.GetActiveScene().name) + 5;
        levelText.text = SceneManager.GetActiveScene().name;
        if (okSayisi < 2)
        {
            bir.text = okSayisi + "";
            iki.text = "";
            uc.text = "";
        }
        else if (okSayisi < 3)
        {
            bir.text = okSayisi + "";
            iki.text = okSayisi - 1 + "";
            uc.text = "";
        }
        else
        {
            bir.text = okSayisi + "";
            iki.text = okSayisi - 1 + "";
            uc.text = okSayisi - 2 + "";
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            kucukCemberOlustur();
            okSayisi--;
            if (okSayisi < 2)
            {
                bir.text = okSayisi + "";
                iki.text = "";
                uc.text = "";
            }
            else if (okSayisi < 3)
            {
                bir.text = okSayisi + "";
                iki.text = okSayisi - 1 + "";
                uc.text = "";
            }
            else
            {
                bir.text = okSayisi + "";
                iki.text = okSayisi - 1 + "";
                uc.text = okSayisi - 2 + "";
            }
            if (okSayisi == 0)
            {
                bir.text = "";
                StartCoroutine(nextLevel(1.5f));
            }
        }
    }
    IEnumerator nextLevel(float waitTieme)
    {
        donenCember.GetComponent<dondurme>().enabled = false;
        AnaCember.GetComponent<anacemberkod>().enabled = false;
        yield return new WaitForSeconds(waitTieme);
        SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1 + "");
    }

    void kucukCemberOlustur()
    {
        Instantiate(kusuckCember, transform.position, transform.rotation);
    }
}

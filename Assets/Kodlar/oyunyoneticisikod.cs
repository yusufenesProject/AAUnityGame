using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class oyunyoneticisikod : MonoBehaviour {

    GameObject donenCember;
    GameObject AnaCember;
    public Animator animator;
	// Use this for initialization
	void Start () {
        donenCember = GameObject.FindGameObjectWithTag("donencembertag");
        AnaCember = GameObject.FindGameObjectWithTag("anacembertag");
	}
	public void oyunBitti()
    {
        StartCoroutine(cagirilanMethod(1));
    }

    IEnumerator cagirilanMethod(float waitTime)
    {
        //donenCember.GetComponent<dondurme>().enabled = false;
        //AnaCember.GetComponent<anacemberkod>().enabled = false;
        //animator.SetTrigger("oyunbitti");
        donenCember.GetComponent<dondurme>().enabled = false;
        AnaCember.GetComponent<anacemberkod>().enabled = false;
        animator.SetTrigger("oyunbitti");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("AnaMenu");

        //SceneManager.LoadScene(int.Parse( SceneManager.GetActiveScene().name)+1);

    }
}

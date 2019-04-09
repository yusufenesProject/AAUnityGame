using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_geriKod : MonoBehaviour {
    GameObject donenCember;
    GameObject AnaCember;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Geri()
    {
        SceneManager.LoadScene("AnaMenu");
    }
}

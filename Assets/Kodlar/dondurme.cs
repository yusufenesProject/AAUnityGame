using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dondurme : MonoBehaviour {

    public float hiz;
    int level;
	// Use this for initialization
	void Start () {
        level=int.Parse(SceneManager.GetActiveScene().name);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, (level + hiz) * Time.deltaTime);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCredits : MonoBehaviour {

    public AudioSource button;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        button.Play();
        SceneManager.LoadScene("Scenes/Credits");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMudo : MonoBehaviour {

    public AudioSource button;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (AudioListener.pause)
        {
            button.Play();
            AudioListener.pause = false;
        }
        else
        {
            button.Play();
            AudioListener.pause = true;
        }
    }
}

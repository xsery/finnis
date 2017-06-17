using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMudo : MonoBehaviour {

    public AudioSource button;
    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (AudioListener.pause)
        {
            anim.SetBool("Mute", true);
        }
        else
        {
            anim.SetBool("Mute", false);
        }
    }

    void OnMouseDown()
    {
        if (AudioListener.pause)
        {
            anim.SetBool("Mute", false);
            button.Play();
            AudioListener.pause = false;
        }
        else
        {
            anim.SetBool("Mute", true);
            button.Play();
            AudioListener.pause = true;
        }
    }
}

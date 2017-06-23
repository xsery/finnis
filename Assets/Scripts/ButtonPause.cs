using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour {

    public AudioSource button;
    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        button.Play();
    }

    void OnMouseEnter()
    {
        anim.SetBool("Mouse", true);
    }
    void OnMouseExit()
    {
        anim.SetBool("Mouse", false);
    }
}

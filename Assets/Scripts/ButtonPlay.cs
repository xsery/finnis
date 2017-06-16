using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour {

    public AudioSource button;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        button.Play();
        SceneManager.LoadScene("Scenes/Memories1");
    }

    void OnMouseEnter()
    {
        anim.SetBool("Play", true);
    }
    void OnMouseExit()
    {
        anim.SetBool("Play", false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCredits : MonoBehaviour {

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
        SceneManager.LoadScene("Scenes/Credits");
    }

    void OnMouseEnter()
    {
        anim.SetBool("Credits", true);
    }
    void OnMouseExit()
    {
        anim.SetBool("Credits", false);
    }
}

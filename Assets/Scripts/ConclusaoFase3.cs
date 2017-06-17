using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConclusaoFase3 : MonoBehaviour {

    public AudioSource portaSounce;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Aberto", false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void doorOpen()
    {
        portaSounce.Play();
        anim.SetBool("Aberto", true);
    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        SceneManager.LoadScene("Scenes/Stage4");
    }

}

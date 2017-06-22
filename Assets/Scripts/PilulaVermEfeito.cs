using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilulaVermEfeito : MonoBehaviour
{


    public GameObject PilulaGameObj;
    public Animator animPorta;
    public Door door;
    public GameObject fundoDoPesadelo;
    public GameObject Mao;
    public GameObject spirits1;
    public GameObject spirits2;
    public AudioSource mundoReal;
    public AudioSource mundoPesadelo;
    public AudioSource remedio;
    private bool pesadelo;

    // Use this for initialization
    void Start()
    {
        fundoDoPesadelo.SetActive(false);
        Mao.SetActive(false);
        spirits1.SetActive(false);
        spirits2.SetActive(false);
        pesadelo = false;
		fundoDoPesadelo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
        
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.name == "Finnis")
        {
            Destroy(PilulaGameObj);
            mundoReal.Stop();
            mundoPesadelo.Play();
            fundoDoPesadelo.SetActive(true);
            Mao.SetActive(true);
            door.doorOpen();
            spirits1.SetActive(true);
            spirits2.SetActive(true);
        }

        if (coll.gameObject.name == "Stage02")
        {
            remedio.Play();
        }

    }

    
}

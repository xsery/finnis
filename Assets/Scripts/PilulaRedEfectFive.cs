using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilulaRedEfectFive : MonoBehaviour
{

    public GameObject PilulaGameObj;
    public Animator animPorta;
    public GameObject fundoDoPesadelo;
    public GameObject Mao;
    public GameObject spirits1;
    public GameObject spirits2;
    public ConclusaoDeFase fase;
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
            spirits1.SetActive(true);
            spirits2.SetActive(true);
            fase.parte2OK();
        }

        if (coll.gameObject.name == "Stage02" || coll.gameObject.name == "Stage05")
        {
            remedio.Play();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlataformaComAlavancas : MonoBehaviour {

	public Rigidbody2D rb2D;
	public Rigidbody2D alavancaVerm;
	public Rigidbody2D alavancaAzul;
	//public Rigidbody2D finnis;
	//public Rigidbody2D bigorna;

    public Plataform finnis;
    public Plataform bigorna;

    public Transform Finnis;
    public Transform Bigorna;

    public float distanciaPercorrer;
	private float posicaoFinal;
	private float mudaPosicao = 0.05f;

	//private bool personagemPlataforma;
	//private bool bigornaPlataforma;

	// Use this for initialization
	void Start () {

		posicaoFinal = rb2D.position.x + distanciaPercorrer;
		Debug.Log (rb2D.position.x + " || " + posicaoFinal);

		/*
		rb2D.transform.position = new Vector2 (rb2D.position.x - 0.5f, rb2D.position.y);
		rb2D.velocity = new Vector2(-0.5f, 0f);
		alavancaAzul.velocity = new Vector2(-0.5f, 0);
		alavancaVerm.velocity = new Vector2 (-0.5f, 0);
		*/
	}
	
	// Update is called once per frame
	void Update () {

		rb2D.transform.position = new Vector2 (rb2D.position.x + mudaPosicao, rb2D.position.y);
		alavancaAzul.transform.position = new Vector2 (alavancaAzul.position.x + mudaPosicao, alavancaAzul.position.y);
		alavancaVerm.transform.position = new Vector2 (alavancaVerm.position.x + mudaPosicao, alavancaVerm.position.y);

        if (finnis.pisouPlataform)
        {
            Finnis.position = new Vector3(Finnis.position.x + mudaPosicao, Finnis.position.y);
        }

        if (bigorna.pisouPlataform)
        {
            Bigorna.position = new Vector3(Bigorna.position.x + mudaPosicao, Bigorna.position.y);
        }

        /*if (personagemPlataforma) {
			finnis.transform.position = new Vector2 (finnis.position.x + mudaPosicao, finnis.position.y);
        }

		if (bigornaPlataforma) {
			bigorna.transform.position = new Vector2 (bigorna.position.x + mudaPosicao, bigorna.position.y);
        }*/

        if (rb2D.position.x > posicaoFinal) {
			mudaPosicao = mudaPosicao * -1;
		} 

		if (rb2D.position.x < -posicaoFinal) {
			mudaPosicao = mudaPosicao * -1;
		}	
	}


	void OnCollisionEnter2D (Collision2D coll2D){

		/*if(coll2D.gameObject.CompareTag("Player"))
		{
			personagemPlataforma = true;
		}

		if (coll2D.gameObject.CompareTag ("Morte")) {
			bigornaPlataforma = true;
		}*/

	}		

}

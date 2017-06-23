using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoSerra : MonoBehaviour {

	//distancia que a serra vai se locomover
	public float distanciaSerra = 4.0f;

	private Rigidbody2D rb2D;
	private float posicaoInicial;
	private float mudaPosicao = 0.03f;


	public float posicaoFinal;



	// Use this for initialization
	void Start () {

		rb2D = GetComponent<Rigidbody2D> ();
		posicaoInicial = rb2D.position.x;

	}

	// Update is called once per frame
	void Update () {

		transform.Rotate (0,0, (700 * Time.deltaTime));

		transform.position = new Vector2 (rb2D.position.x + mudaPosicao, rb2D.position.y);

        if (rb2D.position.x > posicaoFinal) {
			mudaPosicao = mudaPosicao * -1;
		} 

		if (rb2D.position.x < -posicaoFinal) {
			mudaPosicao = mudaPosicao * -1;
		}	

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoSerra : MonoBehaviour {

	//distancia que a serra vai se locomover
	public float distanciaSerra = 4.0f;

	private Rigidbody2D rb2D;
	private float posicaoInicial;



	// Use this for initialization
	void Start () {

		rb2D = GetComponent<Rigidbody2D> ();
		posicaoInicial = rb2D.position.x;
		rb2D.velocity = new Vector2 (1.5f, rb2D.velocity.y);

	}

	// Update is called once per frame
	void Update () {

		rb2D.transform.Rotate (0,0, (700 * Time.deltaTime));

		if (rb2D.position.x > (posicaoInicial + distanciaSerra)) {
			rb2D.velocity = new Vector2 (-1.5f , rb2D.velocity.y);

		}if (rb2D.position.x < (posicaoInicial - distanciaSerra)) {
			rb2D.velocity = new Vector2 (1.5f, rb2D.velocity.y);

		}

	}
}

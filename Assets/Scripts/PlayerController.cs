using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb2D;

	[SerializeField]
	private float velocidade = 0;

	float horizontal;

	// Use this for initialization
	void Start () {

		rb2D = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		horizontal = Input.GetAxis ("Horizontal");

		Movimentar (horizontal);
		
	}

	private void Movimentar(float h){

		rb2D.velocity = new Vector2 (h * velocidade, rb2D.velocity.y);
	}
}

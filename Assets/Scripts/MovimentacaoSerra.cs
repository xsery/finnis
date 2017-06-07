using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoSerra : MonoBehaviour {

	private Rigidbody2D rb2D;


	// Use this for initialization
	void Start () {

		rb2D = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if ( /*rb2D.velocity.x >= 0 && */  rb2D.position.x > 4) {
			Debug.Log ("Direita: " + rb2D.position.x);
			rb2D.velocity = new Vector2 (rb2D.velocity.x + 0.05f , rb2D.velocity.y);
			
		} else if (/* rb2D.velocity.x < 0 && */ rb2D.position.x < -4) {
			Debug.Log ("Esquerda: " + rb2D.position.x);
			rb2D.velocity = new Vector2 (rb2D.velocity.x - 0.05f , rb2D.velocity.y);
			
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaComUmaAlavanca : MonoBehaviour {

	public GameObject rb2D;
	public GameObject alavancaAzul;

    public Transform Finnis;

    public float distanciaPercorrer;
	private float posicaoFinal;
	private float mudaPosicao = 0.01f;

	private bool grounded = false;
	private Transform groundCheck;


	// Use this for initialization
	void Start () {

		posicaoFinal = rb2D.gameObject.transform.position.x + distanciaPercorrer;
		groundCheck = Finnis.transform.Find ("GroundCheck");

	}

	// Update is called once per frame
	void Update () {

		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Plataforma"));

		rb2D.transform.position = new Vector2 (rb2D.gameObject.transform.position.x + mudaPosicao, rb2D.gameObject.transform.position.y);
		alavancaAzul.transform.position = new Vector2 (alavancaAzul.gameObject.transform.position.x + mudaPosicao, alavancaAzul.gameObject.transform.position.y);

		if (grounded)
        {
			
			Finnis.transform.position = new Vector2(Finnis.position.x + mudaPosicao, Finnis.position.y);
        }
			

		if (rb2D.gameObject.transform.position.x > posicaoFinal) {
			mudaPosicao = mudaPosicao * -1;
		} 

		if (rb2D.gameObject.transform.position.x < -posicaoFinal) {
			mudaPosicao = mudaPosicao * -1;
		}	
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DutoAr : MonoBehaviour {

	public Rigidbody2D finnisRigBody;

	private Rigidbody2D rb2D;
	private float posicaoDuto;
	// Use this for initialization
	void Start () {

		rb2D = GetComponent<Rigidbody2D> ();	
		posicaoDuto = rb2D.position.x;


		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void OnMouseDown(){
		if ((finnisRigBody.position.x > (posicaoDuto - 0.80f)) && (finnisRigBody.position.x < (posicaoDuto + 0.80f))){
			finnisRigBody.gravityScale = 0.05f;
			finnisRigBody.transform.position = new Vector2 (finnisRigBody.position.x, finnisRigBody.position.y + 1f);

		}
	}

}

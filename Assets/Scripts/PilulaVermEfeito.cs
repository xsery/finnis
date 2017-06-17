using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilulaVermEfeito : MonoBehaviour {


	public GameObject PilulaGameObj;
	public Animator animPorta;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll){

		if (coll.gameObject.name == "Finnis") {
			Destroy (PilulaGameObj);

			animPorta.SetBool ("Aberto", true);
		}

	}
}

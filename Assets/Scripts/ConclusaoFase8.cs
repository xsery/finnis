using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConclusaoFase8 : MonoBehaviour {

	public Rigidbody2D finnisRB;

	public Door portaNextLevel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void OnCollisionEnter2D(Collision2D colider){

		if (colider.gameObject.CompareTag("Player") ) {

			portaNextLevel.doorOpen();
			Destroy (this.gameObject);
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNurse : MonoBehaviour {

	public Rigidbody2D finnisRigidBody;

	public Rigidbody2D nurseRigidBody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (finnisRigidBody.velocity.x != 0f) {
			nurseRigidBody.velocity = new Vector2 (finnisRigidBody.velocity.x, nurseRigidBody.velocity.y);
		} else {
			nurseRigidBody.velocity = new Vector2 (0f,0f);
		}
		
	}
}

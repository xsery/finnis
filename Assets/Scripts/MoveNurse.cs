using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNurse : MonoBehaviour {

	public Rigidbody2D finnisRigidBody;

	public Transform nurseTransform;

	private Animator anim;
	private bool facingRight = true;


	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();


	}

	// Update is called once per frame
	void Update () {

		if (finnisRigidBody.velocity.x > 0f && nurseTransform.transform.position.x < -3.0f) {
			nurseTransform.transform.position = new Vector2(nurseTransform.transform.position.x + 0.1f, nurseTransform.transform.position.y);
			anim.SetBool ("nurseiddle", false);
			anim.SetBool ("nursemove", true);
		}


		if (finnisRigidBody.velocity.x < 0f && nurseTransform.transform.position.x > -5.0f) {
			nurseTransform.transform.position = new Vector2(nurseTransform.transform.position.x - 0.1f, nurseTransform.transform.position.y);
			anim.SetBool ("nurseiddle", false);
			anim.SetBool ("nursemove", true);
		}
			
		if (nurseTransform.transform.position.x > -3.0f || nurseTransform.transform.position.x < -5.0f) {
			nurseTransform.transform.position = new Vector2 (nurseTransform.transform.position.x, nurseTransform.transform.position.y);
			anim.SetBool ("nurseiddle", true);
			anim.SetBool ("nursemove", false);
		}

		if ((finnisRigidBody.velocity.x > 0f) && !facingRight)
		{
			Flip();
		}
		else if (finnisRigidBody.velocity.x < 0f && facingRight)
		{
			Flip();
		}
    }

	void Flip()
	{

		facingRight = !facingRight;

		nurseTransform.transform.localScale = new Vector2(-nurseTransform.transform.localScale.x, nurseTransform.transform.localScale.y);
	}
}
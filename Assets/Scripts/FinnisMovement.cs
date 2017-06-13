using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinnisMovement : MonoBehaviour {


	public float velocity;
	public float jumpForce;

	private Rigidbody2D rb2d;
	private bool facingRight = true;
	private bool jump;
	private Animator anim;
	private bool grounded = false;

	private Transform groundCheck;


	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		groundCheck = gameObject.transform.Find ("GroundCheck");

		
	}
	
	// Update is called once per frame
	void Update () {

		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));

		if (Input.GetButtonDown ("Jump") && grounded) {

			jump = true;
		}
	}

	void FixedUpdate(){

		float axis = Input.GetAxisRaw ("Horizontal");

		rb2d.velocity = new Vector2 (axis * velocity, rb2d.velocity.y);

		if (axis > 0 && !facingRight) {
			Flip ();
		}
		if (axis < 0 && !facingRight) {
			Flip ();
		}

		if (jump) {
			rb2d.AddForce (new Vector2 (0, jumpForce));
			jump = false;
		}
	}

	void Flip(){

		facingRight = !facingRight;

		Vector3 finnisScale = transform.localScale;
		finnisScale.x *= -1;
		transform.localScale = finnisScale;
	}
	
}

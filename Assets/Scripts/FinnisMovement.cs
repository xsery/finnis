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

		if (rb2d.velocity.y >= 0f && !grounded) {
			anim.SetBool ("Idle", false);
			anim.SetBool ("Jump", true);
			anim.SetBool ("Walk", false);
			anim.SetBool ("JumpDown", false);
		}

		if (rb2d.velocity.y < 0f && !grounded) {
			anim.SetBool ("Idle", false);
			anim.SetBool ("Jump", false);
			anim.SetBool ("Walk", false);
			anim.SetBool ("JumpDown", true);
		}

		if (rb2d.velocity == Vector2.zero && grounded) {
			anim.SetBool ("Idle", true);
			anim.SetBool ("Jump", false);
			anim.SetBool ("Walk", false);
			anim.SetBool ("JumpDown", false);
		}

		if (rb2d.velocity.x != 0 && grounded) {
			anim.SetBool ("Idle", false);
			anim.SetBool ("Jump", false);
			anim.SetBool ("Walk", true);
			anim.SetBool ("JumpDown", false);
		}



	}

	void FixedUpdate(){

		float axis = Input.GetAxisRaw ("Horizontal");

		rb2d.velocity = new Vector2 (axis * velocity, rb2d.velocity.y);

		if ((axis == 1) && !facingRight) {
			Flip ();
		}
		else if ((axis == -1) && facingRight) {
			Flip ();
		}

		if (jump) {
			rb2d.AddForce (new Vector2 (0, jumpForce));
			jump = false;

		}
	}

	void Flip(){

		facingRight = !facingRight;

		rb2d.transform.localScale = new Vector2 (- rb2d.transform.localScale.x, rb2d.transform.localScale.y);
	}
	
}

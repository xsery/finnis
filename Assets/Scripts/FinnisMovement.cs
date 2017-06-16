using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinnisMovement : MonoBehaviour {


	public float velocity;
	public float jumpForce;
    public GameObject sangue;
    private Rigidbody2D rb2d;
	private bool facingRight = true;
	private bool jump;
	private Animator anim;
	private bool grounded = false;
    public bool wakeup;
    public bool discovery;
    public bool dead;

	private Transform groundCheck;


	// Use this for initialization
	void Start () {
        sangue.SetActive(false);
        rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		groundCheck = gameObject.transform.Find ("GroundCheck");

		
	}
	
	// Update is called once per frame
	void Update () {

		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));

		if (Input.GetButtonDown ("Jump") && grounded && !wakeup && !discovery && !dead) {
			jump = true;
		}

		if (rb2d.velocity.y >= 0f && !grounded && !wakeup && !discovery && !dead) {
			anim.SetBool ("Idle", false);
			anim.SetBool ("Jump", true);
			anim.SetBool ("Walk", false);
			anim.SetBool ("JumpDown", false);
            anim.SetBool("WakeUp", false);
            anim.SetBool("Discovery", false);
            anim.SetBool("Dead", false);
        }

		if (rb2d.velocity.y < 0f && !grounded && !wakeup && !discovery && !dead) {
			anim.SetBool ("Idle", false);
			anim.SetBool ("Jump", false);
			anim.SetBool ("Walk", false);
			anim.SetBool ("JumpDown", true);
            anim.SetBool("WakeUp", false);
            anim.SetBool("Discovery", false);
            anim.SetBool("Dead", false);
        }

		if (rb2d.velocity == Vector2.zero && grounded && !wakeup && !discovery && !dead) {
			anim.SetBool ("Idle", true);
			anim.SetBool ("Jump", false);
			anim.SetBool ("Walk", false);
			anim.SetBool ("JumpDown", false);
            anim.SetBool("WakeUp", false);
            anim.SetBool("Discovery", false);
            anim.SetBool("Dead", false);
        }

		if (rb2d.velocity.x != 0 && grounded && !wakeup && !discovery && !dead) {
			anim.SetBool ("Idle", false);
			anim.SetBool ("Jump", false);
			anim.SetBool ("Walk", true);
			anim.SetBool ("JumpDown", false);
            anim.SetBool("WakeUp", false);
            anim.SetBool("Discovery", false);
            anim.SetBool("Dead", false);
        }
    }

	void FixedUpdate(){
        if (!discovery && !wakeup && !dead)
        {
            float axis = Input.GetAxisRaw("Horizontal");

            rb2d.velocity = new Vector2(axis * velocity, rb2d.velocity.y);

            if ((axis == 1) && !facingRight)
            {
                Flip();
            }
            else if ((axis == -1) && facingRight)
            {
                Flip();
            }

            if (jump && !discovery && !wakeup && !dead)
            {
                rb2d.AddForce(new Vector2(0, jumpForce));
                jump = false;

            }
        }
        if (wakeup)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Jump", false);
            anim.SetBool("Walk", false);
            anim.SetBool("JumpDown", false);
            anim.SetBool("WakeUp", true);
            anim.SetBool("Discovery", false);
            anim.SetBool("Dead", false);
        }

        if (discovery)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Jump", false);
            anim.SetBool("Walk", false);
            anim.SetBool("JumpDown", false);
            anim.SetBool("WakeUp", false);
            anim.SetBool("Discovery", true);
            anim.SetBool("Dead", false);
        }
        if (dead)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Jump", false);
            anim.SetBool("Walk", false);
            anim.SetBool("JumpDown", false);
            anim.SetBool("WakeUp", false);
            anim.SetBool("Discovery", false);
            anim.SetBool("Dead", true);
        }
    }

	void Flip(){

		facingRight = !facingRight;

		rb2d.transform.localScale = new Vector2 (- rb2d.transform.localScale.x, rb2d.transform.localScale.y);
	}

    public void PerdeVida()
    {
        StartCoroutine("morte");
    }

    IEnumerator morte()
    {
        sangue.SetActive(true);
        dead = true;
        yield return new WaitForSeconds(1.8f);
        SceneManager.LoadScene("Scenes/Stage1");
    }
}

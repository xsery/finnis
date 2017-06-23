using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseRun : MonoBehaviour {

    public float velocity;
    private Rigidbody2D rb2d;
    private bool facingRight = true;
    private Animator anim;
    public float axis;
    public float pontoMinimo;
    public float pontoMaximo;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        axis = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Idle", false);
        anim.SetBool("Jump", false);
        anim.SetBool("Walk", true);
        anim.SetBool("JumpDown", false);
    }

    void FixedUpdate()
    {
         Input.GetAxisRaw("Horizontal");

        rb2d.velocity = new Vector2(axis * -velocity, rb2d.velocity.y);

        if(transform.position.x < pontoMinimo)
        {
            axis = -1;
        } 

        if(transform.position.x > pontoMaximo)
        {
            axis = 1;
        }

        if ((axis == 1) && facingRight)
        {
            Flip();
        }
        else if ((axis == -1) && !facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        rb2d.transform.localScale = new Vector2(-rb2d.transform.localScale.x, rb2d.transform.localScale.y);
    }
}


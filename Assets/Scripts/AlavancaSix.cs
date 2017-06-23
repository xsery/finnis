using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlavancaSix : MonoBehaviour {

    public bool funcionando;
    private bool alavanca;
    private Animator anim;
    public Rigidbody2D objeto;
    public Animator grancho;
    public float direcao;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            funcionando = true;
        }
    }

    void OnMouseDown()
    {
        if (funcionando)
        {
            if (!alavanca)
            {
                anim.SetBool("funcionando", true);
                transform.position = new Vector3(transform.position.x + direcao, transform.position.y);
                grancho.SetBool("aberto", true);
                objeto.gravityScale = 1;
                alavanca = true;
            }
        }
    }
}

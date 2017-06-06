using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D rd;
    private Transform tr;
    private Animator an;
    public Transform verificaChao;
    public Transform verificaParede;

    private bool estaAndando;
    private bool estaNoChao;
    private bool estaNaParede;
    private bool estaVivo;
    private bool foiDescoberto;
    private bool estaDormindo;
    private bool viradoParaDireta;

    public float axis;
    public float velocidade;
    public float forcaPulo;
    public float raioValidaChao;
    public float raioValidaParede;

    public LayerMask solido;
    

	// Use this for initialization
	void Start () {
        rd = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        an = GetComponent<Animator>();

        estaVivo = true;
        viradoParaDireta = true;
	}

	// Update is called once per frame
	void Update () {
        estaNoChao = Physics2D.OverlapCircle(verificaChao.position, raioValidaChao, solido);
        estaNaParede = Physics2D.OverlapCircle(verificaParede.position, raioValidaParede, solido);

        if (estaVivo)
        {

            axis = Input.GetAxisRaw("Horizontal");

            estaAndando = Mathf.Abs(axis) > 0f;

            if (axis > 0f && !viradoParaDireta)
                Flip();
            else if (axis < 0f && viradoParaDireta)
                Flip();

            if (Input.GetButtonDown("Jump") && estaNoChao)
                rd.AddForce(tr.up * forcaPulo);
            
        }

        Animation();
    }

    void FixedUpdate()
    {

        if (estaAndando)
        {
            if (viradoParaDireta)
                rd.velocity = new Vector2(velocidade, rd.velocity.y);
            else
                rd.velocity = new Vector2(-velocidade, rd.velocity.y);
        }
    }

	private void movimentar(float h){
		
	}

    void Flip()
    {
        viradoParaDireta = !viradoParaDireta;
        tr.localScale = new Vector2(-tr.localScale.x, tr.localScale.y);
    }

    void Animation()
    {
        an.SetBool("Andando", (estaNoChao && estaAndando));
        an.SetBool("Pulando", !estaNoChao);
        an.SetFloat("VelVertical", rd.velocity.y);
        an.SetBool("Morrendo", !estaVivo);
        an.SetBool("Descoberta", !foiDescoberto);
        an.SetBool("Acordando", !estaDormindo);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(verificaChao.position, raioValidaChao);
        Gizmos.DrawWireSphere(verificaParede.position, raioValidaParede);
    }
}

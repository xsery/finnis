using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

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
    void Awake() {
        rd = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        an = GetComponent<Animator>();

        viradoParaDireta = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        EnemyMovements();
	}

    void EnemyMovements()
    {
        estaNoChao = Physics2D.OverlapCircle(verificaChao.position, raioValidaChao, solido);
        estaNaParede = Physics2D.OverlapCircle(verificaParede.position, raioValidaParede, solido);

        if ((!estaNoChao || estaNaParede) && viradoParaDireta)
            Flip();
        else if ((!estaNoChao || estaNaParede) && !viradoParaDireta)
            Flip();

            if (estaNoChao)
            rd.velocity = new Vector2(velocidade, rd.velocity.y);
    }

    void Flip()
    {
        viradoParaDireta = !viradoParaDireta;
        tr.localScale = new Vector2(-tr.localScale.x, tr.localScale.y);

        velocidade *= 1;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(verificaChao.position, raioValidaChao);
        Gizmos.DrawWireSphere(verificaParede.position, raioValidaParede);
    }
}

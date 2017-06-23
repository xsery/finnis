using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlavancaBlueFive : MonoBehaviour {

    public bool funcionando;
    private bool alavancaBlue;
    private Animator anim;
    public GameObject pipula;

    // Use this for initialization
    void Start()
    {
        pipula.SetActive(false);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ///funcionando = false;
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
            if (!alavancaBlue)
            {
                    anim.SetBool("funcionando", true);
                    transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y);
                    pipula.SetActive(true);
                    pipula.transform.position = new Vector3(0.09f, 2.27f);
                    alavancaBlue = true;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlavancaRedFive : MonoBehaviour {
    
    public bool funcionando;
    private bool alavancaRed;
    private Animator anim;
    public MobilePlatformNotMouse mobilePlatform;

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
            if (!alavancaRed)
            {
                    mobilePlatform.activePlatform();
                    anim.SetBool("funcionando", true);
                    transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y);
                    alavancaRed = true;
            }
        }
    }
}

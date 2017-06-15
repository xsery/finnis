using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinnisDiscovery : MonoBehaviour {
    public bool Discovery;
    public FinnisMovement Finnis;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        Discovery = true;
        anim = GetComponent<Animator>();
        StartCoroutine("descoberta");
    }

    // Update is called once per frame
    void Update()
    {
        Finnis.discovery = Discovery;
    }

    IEnumerator descoberta()
    { 
        Discovery = true;
        yield return new WaitForSeconds(4.3f);
        Discovery = false;
    }
}

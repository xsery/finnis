using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinnisDiscovery : MonoBehaviour {
    public bool Discovery;
    public FinnisMovement Finnis;
    private Animator anim;
    public bool pause;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void discovery()
    {
        StartCoroutine("descoberta");
        
    }

    IEnumerator descoberta()
    {
        
        Discovery = true;
        Finnis.discovery = Discovery;
        yield return new WaitForSeconds(4.2f);
        Discovery = false;
        Finnis.discovery = Discovery;

    }
}

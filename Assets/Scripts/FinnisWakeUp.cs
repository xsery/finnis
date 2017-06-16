using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinnisWakeUp : MonoBehaviour {

    public bool WakeUp;
    public FinnisMovement Finnis;
    private Animator anim;

    // Use this for initialization
    void Start () {
        WakeUp = true;
        Finnis.wakeup = WakeUp;
        anim = GetComponent<Animator>();
        StartCoroutine("acordaDoComa");
    }
	
	// Update is called once per frame
	void Update () {
        Finnis.wakeup = WakeUp;
    }

    IEnumerator acordaDoComa()
    { 
        transform.localScale = new Vector3(0.6f, 0.6f);
        WakeUp = true;
        yield return new WaitForSeconds(3.9f);
        yield return new WaitForSeconds(0.5f);
        transform.localScale = new Vector3(0.4f, 0.4f);
        WakeUp = false;
    }
}

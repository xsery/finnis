using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContagemSangue : MonoBehaviour {

    public AudioSource grito;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void iniciaContagem()
    {
        StartCoroutine("action");
    }

    IEnumerator action()
    {
        grito.Play();
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bilhete : MonoBehaviour
{

    public AudioSource bonus;
    public bool mouse;

    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.name == "Finnis")
        {
            transform.localScale = new Vector3(2f, 2f);
            bonus.Play();
            mouse = true;
            transform.localPosition = new Vector3(0, 0);
            GameManager.Instance.CollectLetter();
            Time.timeScale = 0;
        }
    }

    // Use this for initialization
    void Start()
    {
        mouse = false;
    }

    void OnMouseDown()
    {
        if (mouse)
        {
            Time.timeScale = 1;
            bonus.Play();
            gameObject.SetActive(false);
            mouse = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadRemedio : MonoBehaviour {

    private Transform remedio;
    public GameObject Remedio;


    // Use this for initialization
    void Start()
    {
        remedio = GameObject.FindGameObjectWithTag("Remedio").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "Remedio")
        {
            var remedio = colisor.gameObject.GetComponent<DestroiRemedio>();
            remedio.Destroi();
        }
    }

}

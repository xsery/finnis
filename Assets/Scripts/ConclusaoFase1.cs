using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConclusaoFase1 : MonoBehaviour {

    private Transform player;
    public Door door;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            door.doorOpen();
        }
    }
}

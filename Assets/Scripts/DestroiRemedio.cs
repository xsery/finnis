using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiRemedio : MonoBehaviour {

    public GameObject remedio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Destroi()
    {
        Destroy(remedio);
    }
}

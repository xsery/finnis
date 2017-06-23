using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConclusaoDeFase : MonoBehaviour {

    public bool parte1;
    public bool parte2;
    public Door door;

    // Use this for initialization
    void Start () {
        parte1 = false;
        parte2 = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (parte1 && parte2)
        {
            door.doorOpen();
        }
    }

    public void parte1OK()
    {
        parte1 = true;
        
    }

    public void parte2OK()
    {
        parte2 = true;

    }
}

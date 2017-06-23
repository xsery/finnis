using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsFalse : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("comecaFase");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator comecaFase()
    {
        yield return new WaitForSeconds(3f);
        Time.timeScale = 0;
    }

    void OnMouseDown()
    {
        StartCoroutine("destruiJornal");
    }

    IEnumerator destruiJornal()
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
}

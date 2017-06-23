using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirits : MonoBehaviour {
    
    public float movimento;
    public AudioSource mundoPesadelo;

    // Use this for initialization
    void Start () {
        //gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Fantasma2Fase()
    {
        StartCoroutine("fantasmaAndando");
    }

    IEnumerator fantasmaAndando()
    {

        
        yield return new WaitForSeconds(1f);
        transform.position = new Vector2(transform.position.x + movimento, transform.position.y); 
        yield return new WaitForSeconds(1f);
        transform.position = new Vector2(transform.position.x + movimento, transform.position.y);
        yield return new WaitForSeconds(1f);
        transform.position = new Vector2(transform.position.x + movimento, transform.position.y);
        yield return new WaitForSeconds(1f);
        transform.position = new Vector2(transform.position.x + movimento, transform.position.y);
        yield return new WaitForSeconds(1f);
        transform.position = new Vector2(transform.position.x + movimento, transform.position.y);
        yield return new WaitForSeconds(1f);
        transform.position = new Vector2(transform.position.x + movimento, transform.position.y);
        yield return new WaitForSeconds(1f);
        mundoPesadelo.Play();
        gameObject.SetActive(false);
    }
}

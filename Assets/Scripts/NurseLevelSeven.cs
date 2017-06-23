using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseLevelSeven : MonoBehaviour {

	public GameObject blood;
	public List<GameObject> killers = new List<GameObject>();
	AudioSource scream;

	void Awake(){
		scream = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter2D(Collision2D col){
		for (int i = 0; i < killers.Count; i++) {
			if (col.gameObject.name == killers[i].name) {
				StartCoroutine ("BloodOnScreen");
				scream.Play ();
				Destroy (this.gameObject);
			}
		}
	}

	IEnumerator BloodOnScreen(){
		blood.SetActive (true);
		yield return new WaitForSeconds (4);
		blood.SetActive (false);
	}
}

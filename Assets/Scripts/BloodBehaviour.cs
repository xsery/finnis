using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodBehaviour : MonoBehaviour {

	void Update () {
		if (this.gameObject.activeSelf) {
			StartCoroutine ("CleanBlood");
		}
	}

	IEnumerator CleanBlood(){
		yield return new WaitForSeconds (4);
		this.gameObject.SetActive (false);
	}
}

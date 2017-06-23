using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoorLevelSeven : MonoBehaviour {

	public bool isOpen;

	void OnCollisionEnter2D(Collision2D col){
		if ((isOpen) && (col.gameObject.tag == "Player")) {
			SceneManager.LoadScene ("Stage8");
		}
	}
}

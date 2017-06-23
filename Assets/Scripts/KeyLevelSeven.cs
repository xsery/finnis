using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLevelSeven : MonoBehaviour {

	public GameObject door;
	public Sprite openDoor;

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			door.GetComponent<SpriteRenderer> ().sprite = openDoor;
			door.GetComponent<ExitDoorLevelSeven> ().isOpen = true;

			Destroy (this.gameObject);
		}
	}
}

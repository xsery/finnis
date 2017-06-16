using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningPlatform : MonoBehaviour {

	int spriteId = 0;
	public List <Sprite> sprites = new List<Sprite>();
	public bool movableUp;
	public float speed;
	bool goUp;
	bool burning;
	public float burnSpeed;
	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = sprites [spriteId];	
	}
	
	// Update is called once per frame
	void Update () {
		if (goUp) {
			Vector3 newPosition = new Vector3 (
				transform.position.x,
				transform.position.y + (speed/100),
				transform.position.z);
			transform.position = newPosition;
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			StartCoroutine ("StartBurn");
		}
		if (movableUp) {
			goUp = true;
		}
	}

	IEnumerator StartBurn(){
		while (spriteId < sprites.Count) {
			spriteRenderer.sprite = sprites [spriteId];
			spriteId++;
			yield return new WaitForSeconds (burnSpeed);
		}
		Destroy (this.gameObject);
	}
}

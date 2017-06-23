using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStage9 : MonoBehaviour {

	public GameObject portaEletrica;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){

		Debug.Log (portaEletrica.transform.rotation.z);

		if (portaEletrica.transform.rotation.z > -90f){

			portaEletrica.transform.Rotate (0f, 0f, -90f);
			StartCoroutine ("CloseDoor");
		}
		
	}

	IEnumerator CloseDoor()
	{
		portaEletrica.transform.Rotate (0f, 0f, 0f);
		yield return new WaitForSeconds(0.10f);

	}
}

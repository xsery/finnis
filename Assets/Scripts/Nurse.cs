using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : MonoBehaviour {
	public float speed;
	private int angle;


	// Use this for initialization
	void Start () {
		speed = 1;
		angle = 90;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit = new RaycastHit ();
		RaycastHit hit2 = new RaycastHit ();

		if(Physics.Raycast (transform.position, -Vector3.up, out hit, 1f))
		{
			speed = speed;
			angle = angle;
		}
			else
			{
			speed = speed * -1;
			angle = angle * -1;
		}

		if(!Physics.Raycast (transform.position, transform.forward, out hit2, 0.5f))
		{
			speed = speed;
			angle = angle;
		}
		else
		{
			speed = speed * -1;
			angle = angle * -1;
		}
		transform.eulerAngles = new Vector3 (0, angle, 0);
		transform.position += new Vector3(speed, 0, 0)*Time.deltaTime;
		}

	}

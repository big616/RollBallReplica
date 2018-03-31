using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrl : MonoBehaviour {

	public float speed;

	private Rigidbody rb;
	private int count;
	void Start ()
	{ 
		rb = GetComponent<Rigidbody> ();
		count = 0;
	}
	// Update is called once per frame
	void FixedUpdate ()
	{
		float moveHoricontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHoricontal, 0.0f, moveVertical); 

		rb.AddForce (movement * speed); 
	}
	
		void OnTriggerEnter(Collider other) 
		{
		if (other.gameObject.CompareTag ("pickup")) 
		{
			other.gameObject.SetActive (false);
		}
		
	}
}

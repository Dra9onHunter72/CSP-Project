using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour 
{
	public float movementSpeed = 10;
	public float turningSpeed = 10;
	public int jumpHeight = 1;
	public Rigidbody rb;

	void Start ()
	{
		rb = GetComponent <Rigidbody> ();
	}

	void Update ()
	{
		float leftAndRight = Input.GetAxis ("Horizontal") * turningSpeed * Time.deltaTime;
		transform.Translate (leftAndRight, 0, 0);

		float vertical = Input.GetAxis ("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate (0, 0, vertical);

		if (Input.GetKeyDown ("space")) 
		{
			rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
		}
	}
}

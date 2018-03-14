using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour 
{
	public float movementSpeed = 10;
	public float turningSpeed = 1;

	void Update ()
	{
		float leftAndRight = Input.GetAxis ("Horizontal") * turningSpeed * Time.deltaTime;
		transform.Translate (leftAndRight, 0, 0);

		float vertical = Input.GetAxis ("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate (0, 0, vertical);
	}
}

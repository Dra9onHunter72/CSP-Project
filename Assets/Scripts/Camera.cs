using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour 
{
	public GameObject MainCharacter;
	private Vector3 offset;
	void Start ()
	{
		offset == transform.position - MainCharacter.transform.position;
	}

	void LateUpdate ()
	{
		transform.position - MainCharacter.transform.position + offset;
	}




}

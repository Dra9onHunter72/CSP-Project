using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour 
{
	public GameObject target;
	public float rotateSpeed = 5;
	Vector3 offset;

	void Start()
	{
		offset = target.transform.position - transform.position;
	}

	void LateUpdate()
	{
		float horizontal = Input.GetAxis ("Mouse X") * rotateSpeed;
		float vertical = Input.GetAxis ("Mouse Y") * rotateSpeed;
		target.transform.Rotate (vertical, horizontal, 0);

		float desirableAngleH = target.transform.eulerAngles.y;
		float desirableAngleV = target.transform.eulerAngles.x;
		Quaternion rotation = Quaternion.Euler (desirableAngleV , desirableAngleH, 0);
		transform.position = target.transform.position - (rotation * offset);

		transform.LookAt(target.transform);
	}
}

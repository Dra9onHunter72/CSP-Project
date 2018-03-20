using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour 
{
	public GameObject target;
	public float rotateSideWays = 0;
	public float rotateUpAndDown = 0;
	public float minAngle = 0;
	public float maxAngle = 0;
	Vector3 offset;

	void Start()
	{
		offset = target.transform.position - transform.position;
	}

	void LateUpdate()
	{
		float horizontal = Input.GetAxis ("Mouse X") * rotateSideWays;
		float vertical = Input.GetAxis ("Mouse Y") * rotateUpAndDown * Time.deltaTime;
		vertical = Mathf.Clamp (vertical, minAngle, maxAngle);
		transform.eulerAngles = new Vector3 (vertical, 0, 0);
		target.transform.Rotate (vertical, horizontal, 0);

		float desirableAngleH = target.transform.eulerAngles.y;
		float desirableAngleV = target.transform.eulerAngles.x;
		Quaternion rotation = Quaternion.Euler (desirableAngleV , desirableAngleH, 0);
		transform.position = target.transform.position - (rotation * offset);

		transform.LookAt(target.transform);


	}
}

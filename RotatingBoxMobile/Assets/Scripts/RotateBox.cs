using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBox : MonoBehaviour
{
    float rotationSpeed = 10f;
    float xSpeed = 0.0f;
    float ySpeed = 0.0f;
    float zSpeed = 0.0f;
    public bool Rotate = false;
	

    void OnMouseDrag()
    {
        float xSpeed = Input.GetAxis("Mouse X") * rotationSpeed;
        float ySpeed = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.Rotate(Vector3.down, xSpeed);
        transform.Rotate(Vector3.right, ySpeed);
    }
	
    void Update()
    {
        if(Rotate)
	{
		ySpeed = 50;
	}
	else
	{
		ySpeed = 0;
	}
	transform.Rotate(
		xSpeed * Time.deltaTime,
		ySpeed * Time.deltaTime,
		zSpeed * Time.deltaTime
	);
    }
    
    public void ChangeBool()
    {
	Rotate =!Rotate;
    }

}

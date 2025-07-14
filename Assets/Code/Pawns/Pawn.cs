using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Pawn : MonoBehaviour
{
	public float moveSpeed;
	public float rotateSpeed;
	public float jumpHeight;
	public bool isGrounded;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	protected abstract void Start();

	// Update is called once per frame
	protected abstract void Update();

	public virtual void MoveForward()
	{
		Debug.Log("Moving: " + moveSpeed);
	}

	public virtual void MoveBackward()
	{
		Debug.Log("Moving: " + moveSpeed);
	}


	public virtual void RotateRight()
	{
		Debug.Log("Rotating: " + rotateSpeed);
	}

	public virtual void RotateLeft()
	{
		Debug.Log("Rotating: " + rotateSpeed);
	}

	public virtual void Jump()
	{
		Debug.Log("Jumping");
	}

	public virtual void OnCollisionStay()
	{
		if (GetComponent<Rigidbody>().linearVelocity.y <= 0) // Ensures that the tank is grounded for jump check
		{
			isGrounded = true;
		}
		
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TankMover : Mover
{
	private Rigidbody rigidbody;
	private TankPawn tankPawn;

	public override void Start()
	{
		rigidbody = this.gameObject.GetComponent<Rigidbody>();
		tankPawn = this.gameObject.GetComponent<TankPawn>();
	}

	public override void MoveForward(float moveSpeed)
	{
		moveSpeed = moveSpeed * Time.deltaTime; // Apply Delta Time
		rigidbody.MovePosition(rigidbody.position + (transform.forward * moveSpeed)); // Make movement
	}

	public override void MoveBackward(float moveSpeed)
	{
		moveSpeed = moveSpeed * Time.deltaTime; // Apply Delta Time
		rigidbody.MovePosition(rigidbody.position + (-transform.forward * moveSpeed)); // Make movement
	}

	public override void RotateLeft(float rotateSpeed)
	{
		rotateSpeed = rotateSpeed * Time.deltaTime; // Apply Delta Time
		transform.Rotate(0, -rotateSpeed, 0); // Make Rotation
	}

	public override void RotateRight(float rotateSpeed)
	{
		rotateSpeed = rotateSpeed * Time.deltaTime; // Apply Delta Time
		transform.Rotate(0, rotateSpeed, 0); // Make Rotation
	}

	public override void Jump()
	{
		if (tankPawn.isGrounded) // Check for Grouded. Check is located in Pawn.cs
		{
			tankPawn.isGrounded = false; //Apply upward force to simulate jumping
			rigidbody.AddForce(Vector3.up * tankPawn.jumpHeight, ForceMode.Impulse);
		}
	}
}

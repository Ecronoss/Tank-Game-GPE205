using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : Controller
{

	public KeyCode forwardKey;
	public KeyCode backwardKey;
	public KeyCode rightKey;
	public KeyCode leftKey;
	public KeyCode jumpKey;

	public void awake()
    {
        //Add tank player to GM list
        GameManager.gameInstance.players.Add(this);
    }
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
	public override void Start()
	{
		//Runs start from parent
		base.Start();
	}

    // Update is called once per frame
    protected override void Update()
    {
		//Run Update() function from parent class
		base.Update();
    }
	
    public void OnDestroy()
    {
        // Remove player from GM list
        GameManager.gameInstance.players.Remove(this);
    }

	protected override void ProcessInputs()
	{
		//This is specific to Player Controller
		if (Input.GetKey(forwardKey))
		{
			pawn.MoveForward();
		}

		if (Input.GetKey(backwardKey))
		{
			pawn.MoveBackward();
		}

		if (Input.GetKey(leftKey))
		{
			pawn.RotateLeft();
		}

		if (Input.GetKey(rightKey))
		{
			pawn.RotateRight();
		}

		if (Input.GetKeyDown(jumpKey))
		{
			pawn.Jump();
		}

		//Do the parent version of function
		base.ProcessInputs();

	}
}

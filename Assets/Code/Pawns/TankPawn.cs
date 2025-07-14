using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TankPawn : Pawn

{

    public void awake()
    {
        //Add tank pawn to GM list
        GameManager.gameInstance.pawns.Add(this);
    }

    // Start called before first frame update
    protected override void Start()
    {
        mover = GetComponent<TankMover>();
    }

    // Update is called once per frame
    protected override void Update()
    {
    }

    public void OnDestroy()
    {
        // Remove tank from GM list
        GameManager.gameInstance.pawns.Remove(this);
    }

    private TankMover mover;
	
    //Forward Backward movement
	public override void MoveForward()
    {
        mover.MoveForward(moveSpeed);
    }

    public override void MoveBackward()
    {
        mover.MoveBackward(moveSpeed);
    }

    //Rotation
    public override void RotateRight()
    {
        mover.RotateRight(rotateSpeed);
    }

    public override void RotateLeft()
    {
        mover.RotateLeft(rotateSpeed);
    }
	
    //Jumping
    public override void Jump()
    {
        mover.Jump();
    }


}

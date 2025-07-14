using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Controller : MonoBehaviour
{
	
	//Variable for holding Pawn
	public Pawn pawn;
		
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
		ProcessInputs();
    }

  protected virtual void ProcessInputs()
  {
    
	}

}

using UnityEngine;
using System.Collections;
using System;

public class Delegates : MonoBehaviour {

	Action<Delegates> Move;
	Action Idle;
	Action Jump;

	int speed = 200;


	void MoveHandler (Delegates obj)
	{
		print("Moving at " + obj.speed + " mph.");
		Move = null;
		Idle = IdleHandler;
	}

	void IdleHandler ()
	{
		print("Idling");
		Idle = null;
		Jump = JumpHandler;

	}

	void JumpHandler ()
	{
		print("Jumping");
		Jump = null;
	}

	// Use this for initialization
	void Start () {
		Move = MoveHandler;

	}


	// Update is called once per frame
	void Update () {
	if(Move != null)
		Move(this);
	if(Idle != null)
		Idle();
	if(Jump != null)
		Jump();
	}
}

using UnityEngine;
using System.Collections;
using System;

public class UserInputs : MonoBehaviour {

	public static Action<KeyCode> UserInput;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.RightArrow) && UserInput != null)
		{
			UserInput(KeyCode.RightArrow);
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow) && UserInput != null)
		{
			UserInput(KeyCode.LeftArrow);
		}
		if(Input.GetKeyDown(KeyCode.UpArrow) && UserInput != null)
		{
			UserInput(KeyCode.UpArrow);
		}
		if(Input.GetKeyDown(KeyCode.DownArrow) && UserInput != null)
		{
			UserInput(KeyCode.DownArrow);
		}

	}
}

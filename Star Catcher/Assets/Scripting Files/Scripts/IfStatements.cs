using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

	public bool isDoorUnlocked = false;

	void OnMouseDown () {
		if (isDoorUnlocked)
		{
			Enter();
		} else 
		{
			Exit();
		}
	
	}

	private void Enter () {
		print ("Speak friend and enter");
	}

	private void Exit ()
	{
		print ("The way is shut -- They are coming!");
	}

}

using UnityEngine;
using System.Collections;

public class switchStatement : MonoBehaviour {

	public enum gameStates {Starting, Playing, Ending} 
	public gameStates currentState = gameStates.Starting;

	// Use this for initialization
	void Start () {
		switch (currentState)
			{
				case gameStates.Starting:
				DoSomething("Starting", gameStates.Playing);
				break;

				case gameStates.Playing:
				DoSomething("Playing", gameStates.Ending);
				break;

				case gameStates.Ending:
				DoSomething("Ending",gameStates.Ending);
				break;
 		}
 	}

 		private void DoSomething (string v, gameStates gs)
 		{
 			
 			print ("The game is " + v);
 			if(gs != gameStates.Ending)
 			Start();
			currentState = gs;
 		}	
}
